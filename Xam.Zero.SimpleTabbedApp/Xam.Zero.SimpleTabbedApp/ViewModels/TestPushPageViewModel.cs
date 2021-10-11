using System;
using System.Collections.Generic;
using System.Text;
using Xam.Zero.ViewModels;

namespace Xam.Zero.SimpleTabbedApp.ViewModels
{
    class TestPushPageViewModel : ZeroBaseModel
    {
        protected override void PrepareModel(object data)
        {
            Console.WriteLine("Test", data);
            base.PrepareModel(data);
        }
    }
}
