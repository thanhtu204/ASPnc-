#pragma checksum "C:\Users\Windows 10\Desktop\HaTuanAnh_ASP.Core\MinhHoa1\MinhHoa1\Views\TNAnh\XuLy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00af46b10dcb8235f57eb2a7d5c620c7303c5bdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TNAnh_XuLy), @"mvc.1.0.view", @"/Views/TNAnh/XuLy.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Windows 10\Desktop\HaTuanAnh_ASP.Core\MinhHoa1\MinhHoa1\Views\_ViewImports.cshtml"
using MinhHoa1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Windows 10\Desktop\HaTuanAnh_ASP.Core\MinhHoa1\MinhHoa1\Views\_ViewImports.cshtml"
using MinhHoa1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00af46b10dcb8235f57eb2a7d5c620c7303c5bdb", @"/Views/TNAnh/XuLy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee582e3757d2d52fd9131c9a2ebcf39382bb054a", @"/Views/_ViewImports.cshtml")]
    public class Views_TNAnh_XuLy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Person>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>\r\n    Thong tin dang ky\r\n</h3>\r\n<hr />\r\n\r\n<li>Ho ten: ");
#nullable restore
#line 8 "C:\Users\Windows 10\Desktop\HaTuanAnh_ASP.Core\MinhHoa1\MinhHoa1\Views\TNAnh\XuLy.cshtml"
       Write(Model.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n<li>Ngay sinh: ");
#nullable restore
#line 9 "C:\Users\Windows 10\Desktop\HaTuanAnh_ASP.Core\MinhHoa1\MinhHoa1\Views\TNAnh\XuLy.cshtml"
          Write(Model.BirtDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n<li>\r\n    Hinh dai dien:<br />\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "00af46b10dcb8235f57eb2a7d5c620c7303c5bdb4069", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 181, "~/img/", 181, 6, true);
#nullable restore
#line 13 "C:\Users\Windows 10\Desktop\HaTuanAnh_ASP.Core\MinhHoa1\MinhHoa1\Views\TNAnh\XuLy.cshtml"
AddHtmlAttributeValue("", 187, Model.Picture, 187, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
