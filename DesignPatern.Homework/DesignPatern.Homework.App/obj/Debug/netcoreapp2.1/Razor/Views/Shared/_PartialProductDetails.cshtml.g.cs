#pragma checksum "C:\Users\Ilija\Desktop\MVC_Homework\DesignPatern.Homework\DesignPatern.Homework.App\Views\Shared\_PartialProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ee13e8f20b0adbddfa8b6f9668e5f4727def63e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialProductDetails), @"mvc.1.0.view", @"/Views/Shared/_PartialProductDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PartialProductDetails.cshtml", typeof(AspNetCore.Views_Shared__PartialProductDetails))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Ilija\Desktop\MVC_Homework\DesignPatern.Homework\DesignPatern.Homework.App\Views\_ViewImports.cshtml"
using DesignPatern.Homework.App;

#line default
#line hidden
#line 2 "C:\Users\Ilija\Desktop\MVC_Homework\DesignPatern.Homework\DesignPatern.Homework.App\Views\_ViewImports.cshtml"
using DesignPatern.Homework.App.Models;

#line default
#line hidden
#line 3 "C:\Users\Ilija\Desktop\MVC_Homework\DesignPatern.Homework\DesignPatern.Homework.App\Views\_ViewImports.cshtml"
using DesignPatern.Homework.BusinessLayer;

#line default
#line hidden
#line 4 "C:\Users\Ilija\Desktop\MVC_Homework\DesignPatern.Homework\DesignPatern.Homework.App\Views\_ViewImports.cshtml"
using DesignPatern.Homework.BusinessLayer.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\Ilija\Desktop\MVC_Homework\DesignPatern.Homework\DesignPatern.Homework.App\Views\_ViewImports.cshtml"
using DesignPatern.Homework.DataLayer.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ee13e8f20b0adbddfa8b6f9668e5f4727def63e", @"/Views/Shared/_PartialProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"177fdff94d8f635d43c89a3623ab7b409b4125db", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 40, true);
            WriteLiteral("\r\n<h3>Product Details:</h3>\r\n\r\n<p>Name: ");
            EndContext();
            BeginContext(59, 10, false);
#line 5 "C:\Users\Ilija\Desktop\MVC_Homework\DesignPatern.Homework\DesignPatern.Homework.App\Views\Shared\_PartialProductDetails.cshtml"
    Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(69, 22, true);
            WriteLiteral("</p>\r\n<p>Description: ");
            EndContext();
            BeginContext(92, 17, false);
#line 6 "C:\Users\Ilija\Desktop\MVC_Homework\DesignPatern.Homework\DesignPatern.Homework.App\Views\Shared\_PartialProductDetails.cshtml"
           Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(109, 19, true);
            WriteLiteral("</p>\r\n<p>Category: ");
            EndContext();
            BeginContext(129, 14, false);
#line 7 "C:\Users\Ilija\Desktop\MVC_Homework\DesignPatern.Homework\DesignPatern.Homework.App\Views\Shared\_PartialProductDetails.cshtml"
        Write(Model.Category);

#line default
#line hidden
            EndContext();
            BeginContext(143, 16, true);
            WriteLiteral("</p>\r\n<p>Price: ");
            EndContext();
            BeginContext(160, 11, false);
#line 8 "C:\Users\Ilija\Desktop\MVC_Homework\DesignPatern.Homework\DesignPatern.Homework.App\Views\Shared\_PartialProductDetails.cshtml"
     Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(171, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
