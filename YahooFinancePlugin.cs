namespace YahooFinanceADPlugin
{
    using System.ComponentModel.Composition;
    using Codefarts.AutoDownloader;
    using Codefarts.AutoDownloader.Interfaces;

    [Export(typeof(ISourcePlugin))]
    [SourcePlugin("Yahoo Finance")]
    public class YahooFinancePlugin : ISourcePlugin
    {
        private bool isRunning;
        private ApplicationModel applicationModel;

        public string Title
        {
            get
            {
                return "Yahoo Finance";
            }
        }

        public bool IsRunning
        {
            get
            {
                return this.isRunning;
            }
        }

        public void Run()
        {
            if (this.isRunning)
            {
                return;
            }

            this.isRunning = true;
            this.isRunning = false;
        }

        public void Stop()
        {
            this.isRunning = false;
        }

        public ApplicationModel Application
        {
            get
            {
                return this.applicationModel;
            }
        }

        public void Connect(ApplicationModel appModel)
        {
            this.applicationModel = appModel;
        }

        public void Disconnect()
        {
            this.Stop();
            this.applicationModel = null;
        }
    }
}
