#pragma checksum "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Position\Recruitment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f19b5a3abeeef5a8db83a96b904b4b341a74f564"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PayrollAdmin_Views_Position_Recruitment), @"mvc.1.0.view", @"/Areas/PayrollAdmin/Views/Position/Recruitment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/PayrollAdmin/Views/Position/Recruitment.cshtml", typeof(AspNetCore.Areas_PayrollAdmin_Views_Position_Recruitment))]
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
#line 1 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\_ViewImports.cshtml"
using FinalProject.Areas.PayrollAdmin.Models;

#line default
#line hidden
#line 2 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\_ViewImports.cshtml"
using FinalProject.Areas.PayrollAdmin.Enum;

#line default
#line hidden
#line 3 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\_ViewImports.cshtml"
using FinalProject.Areas.PayrollAdmin.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f19b5a3abeeef5a8db83a96b904b4b341a74f564", @"/Areas/PayrollAdmin/Views/Position/Recruitment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b33cf539e6b39c202c86cf123e88520ee5492aef", @"/Areas/PayrollAdmin/Views/_ViewImports.cshtml")]
    public class Areas_PayrollAdmin_Views_Position_Recruitment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecruitmentPaginationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Position", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Recruitment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:70px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:30px; height:30px; border-radius:100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PositionChanged", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addrecruitment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn bg-color text-white btn-rounded float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Position\Recruitment.cshtml"
  
    ViewData["Title"] = "Recruitment";

#line default
#line hidden
            BeginContext(88, 492, true);
            WriteLiteral(@"
<div class=""page-wrapper padding-top"">
    <div class=""container"">

        <div class=""row list-row bg-color"">
            <div class=""col-xl-12 my-border"">
                <h4 class=""page-title text-white""> <i class=""fas fa-exchange-alt mr-3""></i> Vəzifənin dəyişilməsi</h4>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-xl-12"">
                <div class=""portlet light mb"" style=""padding: 15px 20px 8px 15px;"">
                    ");
            EndContext();
            BeginContext(580, 3403, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fff14532f0cf4c699a7cc26829a771d6", async() => {
                BeginContext(607, 594, true);
                WriteLiteral(@"
                        <div class=""form-row employee"">
                            <div class=""form-group col-xl-5 ml-0"">
                                <input id=""positionChangedName"" class=""form-control search-input"" placeholder=""Vəzifəsi dəyişiləcək işçi"" />
                            </div>
                            <div class=""col-xl-1"">
                                <button type=""submit"" class=""btn btn-block bg-color searchChangedPosition""><i class=""fas fa-sync-alt""></i></button>
                            </div>
                            <div class=""col-xl-6"">
");
                EndContext();
#line 28 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Position\Recruitment.cshtml"
                                 if (Model.PaginationModel.TotalPages != 1)
                                {
                                    var currentPage = Model.PaginationModel.CurrentPage;


#line default
#line hidden
                BeginContext(1405, 220, true);
                WriteLiteral("                                    <ul class=\"pagination float-right\">\r\n\r\n                                        <li class=\"page-item\"><a class=\"page-link\" href=\"#\"><i class=\"fas fa-angle-double-left\"></i></a></li>\r\n\r\n");
                EndContext();
#line 36 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Position\Recruitment.cshtml"
                                          
                                            var startPaginationPage = currentPage;
                                            if (currentPage == 2)
                                            {
                                                startPaginationPage = currentPage - 1;
                                            }
                                            else if (currentPage == 3)
                                            {
                                                startPaginationPage = currentPage - 2;
                                            }
                                            else if (currentPage != 1)
                                            {
                                                startPaginationPage = (currentPage > 3) ? currentPage - 1 : currentPage;
                                            }
                                        

#line default
#line hidden
                BeginContext(2587, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 52 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Position\Recruitment.cshtml"
                                         for (int i = startPaginationPage; (i <= currentPage + 1 && i <= Model.PaginationModel.TotalPages); i++)
                                        {
                                            var page = new Dictionary<string, string>()
                                                                                                                                            {
                                              { "page", i.ToString() }
                                            };

                                            var classAttr = "";

                                            if (i == currentPage)
                                            {
                                                classAttr = "active";
                                            }


#line default
#line hidden
                BeginContext(3433, 66, true);
                WriteLiteral("                                            <li class=\"page-item\">");
                EndContext();
                BeginContext(3499, 115, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f396298220dc4d7d9853dfa3dac1df35", async() => {
                    BeginContext(3609, 1, false);
#line 66 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Position\Recruitment.cshtml"
                                                                                                                                                                          Write(i);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3509, "page-link", 3509, 9, true);
#line 66 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Position\Recruitment.cshtml"
AddHtmlAttributeValue(" ", 3518, classAttr, 3519, 10, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 66 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Position\Recruitment.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = page;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3614, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 67 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Position\Recruitment.cshtml"
                                        }

#line default
#line hidden
                BeginContext(3664, 189, true);
                WriteLiteral("\r\n                                        <li class=\"page-item\"><a class=\"page-link\" href=\"#\"><i class=\"fas fa-angle-double-right\"></i></a></li>\r\n                                    </ul>\r\n");
                EndContext();
#line 71 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Position\Recruitment.cshtml"
                                }

#line default
#line hidden
                BeginContext(3888, 88, true);
                WriteLiteral("                            </div>\r\n                        </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3983, 653, true);
            WriteLiteral(@"
                    <table class=""table table-striped table-bordered positionChanged mt-4"">
                        <thead>
                            <tr>
                                <th><i class=""far fa-image""></i></th>
                                <th>Ad</th>
                                <th>Soyad</th>
                                <th>Tel</th>
                                <th>Email</th>
                                <th>Vəzifə</th>
                                <th>İşə başlama tarixi</th>
                                <th>Əməliyyat</th>
                            </tr>
                        </thead>

");
            EndContext();
#line 89 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Position\Recruitment.cshtml"
                         foreach (var item in Model.Recruitments)
                        {

#line default
#line hidden
            BeginContext(4730, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(4800, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ae1b52b5da0c466a853c0819ad1694fe", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4884, "~/img/", 4884, 6, true);
#line 92 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Position\Recruitment.cshtml"
AddHtmlAttributeValue("", 4890, item.Employee.Image, 4890, 20, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4914, 44, true);
            WriteLiteral("</td>\r\n                                <td> ");
            EndContext();
            BeginContext(4959, 23, false);
#line 93 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Position\Recruitment.cshtml"
                                Write(item.Employee.Firstname);

#line default
#line hidden
            EndContext();
            BeginContext(4982, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(5026, 22, false);
#line 94 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Position\Recruitment.cshtml"
                               Write(item.Employee.Lastname);

#line default
#line hidden
            EndContext();
            BeginContext(5048, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(5092, 19, false);
#line 95 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Position\Recruitment.cshtml"
                               Write(item.Employee.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(5111, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(5155, 19, false);
#line 96 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Position\Recruitment.cshtml"
                               Write(item.Employee.Email);

#line default
#line hidden
            EndContext();
            BeginContext(5174, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(5218, 18, false);
#line 97 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Position\Recruitment.cshtml"
                               Write(item.Position.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5236, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(5280, 36, false);
#line 98 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Position\Recruitment.cshtml"
                               Write(item.WhenStarted.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(5316, 81, true);
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(5397, 298, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be6d43920ccd468890552dee6716fee8", async() => {
                BeginContext(5529, 162, true);
                WriteLiteral("\r\n                                        <i class=\"fas fa-exchange-alt\"></i>\r\n                                        dəyiş\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 100 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Position\Recruitment.cshtml"
                                                                      WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5695, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 106 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Position\Recruitment.cshtml"
                        }

#line default
#line hidden
            BeginContext(5798, 100, true);
            WriteLiteral("                        <tr class=\"d-none\" id=\"trChangedPosition\">\r\n                            <td>");
            EndContext();
            BeginContext(5898, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "56c2dd9edcf64e279c3c2cfb879577f4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5992, 850, true);
            WriteLiteral(@"</td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td>
                                <a id=""addrecruitment"" class=""btn bg-color text-white btn-rounded float-right"">
                                    <i class=""fas fa-exchange-alt""></i>
                                    dəyiş
                                </a>
                            </td>
                        </tr>
                    </table>

                    <span id=""positionChangedNotFoundError"" class=""text-danger mt-3 bold"" style=""font-size:20px;""></span>

                </div>
            </div>
        </div>
   
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecruitmentPaginationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
