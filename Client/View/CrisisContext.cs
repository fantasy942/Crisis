using System.Threading.Tasks;
using Crisis.Model;
using Crisis.Messages;
using System;

namespace Crisis.View
{
    class CrisisContext : System.Windows.Forms.ApplicationContext
    {
        private readonly CrisisModel model = new CrisisModel();

        private readonly LoginForm loginForm;
        private readonly ConnectForm connectForm = new ConnectForm();
        private readonly MainForm mainForm;

        public CrisisContext()
        {
            loginForm = new LoginForm(model);
            mainForm = new MainForm(model);

            _ = DoAsync();
        }

        private async Task DoAsync()
        {
            while (true)
            {
                //As the actual main is not yet ready we place loginForm as the MainForm.
                //This enables us to terminate from the loginForm on demand.
                MainForm = loginForm;
                loginForm.Show();
                connectForm.Hide();
                mainForm.Hide();

                var AwaitLogin = new TaskCompletionSource<object>();
                void local() => AwaitLogin.SetResult(null);
                loginForm.LoginPressed += local;
                await AwaitLogin.Task;
                loginForm.LoginPressed -= local;

                //Order matters, if we close loginForm first then the whole application will shut itself down
                MainForm = connectForm;
                loginForm.Hide();
                connectForm.Show();

                //client.Connect("192.223.30.122", 4242);
                var result = await model.Connect("localhost", 4242, loginForm.Username, loginForm.Password);

                if (result == ConnectAttemptResult.GenericFail)
                {
                    loginForm.Error = "Connection failed.";
                    continue;
                }
                else if (result == ConnectAttemptResult.AuthFail)
                {
                    loginForm.Error = "Provided username or password was wrong.";
                    continue;
                }
                loginForm.Error = string.Empty;

                MainForm = mainForm;
                connectForm.Hide();
                mainForm.Show();

                while (true)
                {
                    const int limit = 500;
                    for (int i = 0; i < limit && model.TryPopMessage(out Message msg); i++)
                    {
                        if (msg is HearMessage hmsg)
                        {
                            mainForm.ToChat($"{hmsg.Time}{Environment.NewLine}{hmsg.Rank} {hmsg.Name}: {hmsg.Text}");
                        }
                    }
                    await Task.Delay(1); //Let the UI breath
                }
            }
        }
    }
}
