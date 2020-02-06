﻿using System.Threading.Tasks;
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
                var result = await model.Connect("localhost", 4242, new Messages.Client.AuthMessage { Mail = loginForm.Username, Password = loginForm.Password });

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

                await new TaskCompletionSource<object>().Task; //Wait forever. Temporary solution.
            }
        }
    }
}
