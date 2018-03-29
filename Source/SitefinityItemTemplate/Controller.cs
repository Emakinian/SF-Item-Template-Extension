using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;
using Telerik.Sitefinity.Mvc;
using System.Web.Mvc;
using System.ComponentModel;
using Pmi.Core.Interfaces.Services;
using Pmi.Widgets.Mvc.Models.$fileinputname$Widget;
using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Controllers.Attributes;
using Telerik.Sitefinity.Modules.Pages.Configuration;

namespace $ControllerNamespace$
{
    [ControllerToolboxItem(Name = "$fileinputname$Widget",
            Title = "$fileinputname$ Widget",
            SectionName = ToolboxesConfig.ContentToolboxSectionName, 
            CssClass = WidgetIconCssClass)]
    [EnhanceViewEngines]
    public class $fileinputname$WidgetController : $Controller$
	{

        private const string WidgetIconCssClass = "sfContentBlockIcn sfMvcIcn";
        private string _templateName = "Default";
        private string _templateNamePrefix = "$fileinputname$.";

        private readonly ILoggingService _loggingService;

        private $fileinputname$Model _model;

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public $fileinputname$Model Model => _model ?? (_model = new $fileinputname$Model());

        public $fileinputname$WidgetController(ILoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        public ActionResult Index()
        {
            var viewModel = new $fileinputname$ViewModel();
            //Fill here.

            return View(_templateNamePrefix + _templateName, viewModel);
        }
    }
}
