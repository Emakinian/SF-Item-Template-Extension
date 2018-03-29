using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;

namespace SitefinityWidgetWizard
{
    public class SitefinityWidgetWizard : IWizard
    {
        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            //  Create the form.
            var form = new Form1();

            //  Show the form.
            form.ShowDialog();

            //  Add the options to the replacementsDictionary.
            for (var index = 0; index < form.ModelItems.Count; index++)
            {
                replacementsDictionary.Add("$ModelName" + index + "$", form.ModelItems[index].PropertyName);
                replacementsDictionary.Add("$ModelIsRequired" + index + "$", form.ModelItems[index].IsRequired);
                replacementsDictionary.Add("$ModelType" + index + "$", form.ModelItems[index].PropertyType);
            }

        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }

        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void RunFinished()
        {
        }
    }
}
