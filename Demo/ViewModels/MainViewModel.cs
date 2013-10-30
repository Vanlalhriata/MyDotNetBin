using Demo.Models;
using MyDotNetBin.Utils;
using System;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace Demo.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        #region Commands

        #region DemoXmlPersistor
        
        private ICommand _DemoXmlPersistorCommand;
        public ICommand DemoXmlPersistorCommand
        {
            get
            {
                if (_DemoXmlPersistorCommand == null)
                {
                    _DemoXmlPersistorCommand = new RelayCommand<object>(DemoXmlPersistor_Executed);
                }
                return _DemoXmlPersistorCommand;
            }
        }

        private void DemoXmlPersistor_Executed(object parameter)
        {
            DemoXmlPersistor();
        }

        #endregion

        #region DemoUtility

        private ICommand _DemoUtilityCommand;
        public ICommand DemoUtilityCommand
        {
            get
            {
                if (_DemoUtilityCommand == null)
                {
                    _DemoUtilityCommand = new RelayCommand<object>(DemoUtilityCommand_Executed);
                }
                return _DemoUtilityCommand;
            }
        }

        private void DemoUtilityCommand_Executed(object parameter)
        {
            DemoUtility();
        }

        #endregion

        #endregion Commands

        #region Command executed methods

        private void DemoXmlPersistor()
        {
            // Demo Write
            TestModel model = new TestModel() { StringA = "Persist me!" };
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            filename = Path.Combine(filename, "Test.xml");

            XmlPersistor.WriteXml<TestModel>(filename, model);

            // Demo Read
            var readModel = new TestModel();
            XmlPersistor.ReadXml<TestModel>(filename, ref readModel);
        }

        private void DemoUtility()
        {
            TestModel aVariable = new TestModel();
            string name = Utility.GetVariableName(x => aVariable);
            MessageBox.Show("Variable name: " + name);
        }

        #endregion Command executed methods

    }
}
