#pragma checksum "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Company\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abdd0c4bb09da51762d6aaf7ebdf2194dfa06f7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PayrollAdmin_Views_Company_List), @"mvc.1.0.view", @"/Areas/PayrollAdmin/Views/Company/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/PayrollAdmin/Views/Company/List.cshtml", typeof(AspNetCore.Areas_PayrollAdmin_Views_Company_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abdd0c4bb09da51762d6aaf7ebdf2194dfa06f7f", @"/Areas/PayrollAdmin/Views/Company/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b33cf539e6b39c202c86cf123e88520ee5492aef", @"/Areas/PayrollAdmin/Views/_ViewImports.cshtml")]
    public class Areas_PayrollAdmin_Views_Company_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompanyPaginationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn bg-color text-white btn-rounded float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Company", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn bg-color"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-color btn text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Company\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(75, 442, true);
            WriteLiteral(@"
<div class=""page-wrapper padding-top"">
    <div class=""container"">

        <div class=""row list-row bg-color"">
            <div class=""col-xl-12 my-border"">
                <h4 class=""page-title text-white""><i class=""fas fa-list mr-3""></i> Şirkətlərin siyahısı</h4>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-xl-12"">
                <div class=""portlet light"">
                    ");
            EndContext();
            BeginContext(517, 3498, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "115964de01f240d5a92a757a2131931f", async() => {
                BeginContext(523, 633, true);
                WriteLiteral(@"
                        <div class=""form-row employee"">
                            <div class=""form-group col-xl-5 ml-0"">
                                <input id=""companyName"" class=""form-control search-input"" type=""text"" placeholder=""Şirkətin adı"" />
                            </div>
                            <div class=""col-xl-1"">
                                <button type=""submit"" class=""btn btn-block bg-color searchCompany""><i class=""fas fa-search""></i> </button>
                            </div>

                            <div class=""col-xl-2 text-right offset-xl-2"">
                                ");
                EndContext();
                BeginContext(1156, 234, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9ed08d78eda4912affde18ed39d48ac", async() => {
                    BeginContext(1235, 151, true);
                    WriteLiteral("\r\n                                    <i class=\"fa fa-plus\"></i>\r\n                                    Şirkət əlavə et\r\n                                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1390, 40, true);
                WriteLiteral("\r\n                            </div>\r\n\r\n");
                EndContext();
#line 34 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Company\List.cshtml"
                             if (Model.PaginationModel.TotalPages != 1)
                            {
                                var currentPage = Model.PaginationModel.CurrentPage;


#line default
#line hidden
                BeginContext(1622, 217, true);
                WriteLiteral("                                <ul class=\"pagination float-right ml-3\">\r\n\r\n                                    <li class=\"page-item\"><a class=\"page-link\" href=\"#\"><i class=\"fas fa-angle-double-left\"></i></a></li>\r\n\r\n");
                EndContext();
#line 42 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Company\List.cshtml"
                                      
                                        var startPaginationPage = currentPage;
                                        if (currentPage == 3 || currentPage == 2)
                                        {
                                            startPaginationPage = currentPage - 1;
                                        }
                                        else if (currentPage != 1)
                                        {
                                            startPaginationPage = (currentPage > 3) ? currentPage - 1 : currentPage;
                                        }
                                    

#line default
#line hidden
                BeginContext(2523, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 54 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Company\List.cshtml"
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
                BeginContext(3527, 62, true);
                WriteLiteral("                                        <li class=\"page-item\">");
                EndContext();
                BeginContext(3589, 107, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8e9da1733df4a02898e4ccd3263143b", async() => {
                    BeginContext(3691, 1, false);
#line 68 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Company\List.cshtml"
                                                                                                                                                              Write(i);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3599, "page-link", 3599, 9, true);
#line 68 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Company\List.cshtml"
AddHtmlAttributeValue(" ", 3608, classAttr, 3609, 10, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 68 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Company\List.cshtml"
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
                BeginContext(3696, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 69 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Company\List.cshtml"
                                    }

#line default
#line hidden
                BeginContext(3742, 181, true);
                WriteLiteral("\r\n                                    <li class=\"page-item\"><a class=\"page-link\" href=\"#\"><i class=\"fas fa-angle-double-right\"></i></a></li>\r\n                                </ul>\r\n");
                EndContext();
#line 73 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Company\List.cshtml"
                            }

#line default
#line hidden
                BeginContext(3954, 54, true);
                WriteLiteral("\r\n                        </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4015, 343, true);
            WriteLiteral(@"

                </div>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-xl-12"">
                <span id=""companyNotFoundError"" class=""text-danger mt-3 bold"" style=""font-size:20px;""></span>
            </div>
        </div>

        <div class=""row companyClone"" style=""margin-top:6px;"">
");
            EndContext();
#line 89 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Company\List.cshtml"
             foreach (var item in Model.Companies)
            {

#line default
#line hidden
            BeginContext(4425, 512, true);
            WriteLiteral(@"                <div class=""col-xl-3"">
                    <div class=""profile-widget shop"">
                        <div class=""dropdown profile-action"">
                            <a class=""action-icon dropdown-toggle"" data-toggle=""dropdown"" aria-expanded=""false""></a>
                            <div class=""dropdown-menu departament dropdown-menu-right"">
                                <ul class=""action departament"">
                                    <li>
                                        ");
            EndContext();
            BeginContext(4937, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fd8feb5578b4d3fbe4973c614be7661", async() => {
                BeginContext(5016, 26, true);
                WriteLiteral("<i class=\"fas fa-pen\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 98 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Company\List.cshtml"
                                                                            WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5046, 154, true);
            WriteLiteral("\r\n                                    </li>\r\n                                    <li>\r\n                                        <a title=\"Delete\" data-id=\"");
            EndContext();
            BeginContext(5201, 7, false);
#line 101 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Company\List.cshtml"
                                                              Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(5208, 295, true);
            WriteLiteral(@""" class=""bg-color btn text-white companyDelete"">
                                            <i class=""fas fa-trash""></i>
                                        </a>
                                    </li>
                                    <li>
                                        ");
            EndContext();
            BeginContext(5503, 241, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b72a826e284f41b69c159739ef0fc23a", async() => {
                BeginContext(5618, 122, true);
                WriteLiteral("\r\n                                            <i class=\"fas fa-info-circle\"></i>\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            BeginWriteTagHelperAttribute();
#line 106 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Company\List.cshtml"
                                                               Write(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-id", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 106 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Company\List.cshtml"
                                                                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5744, 196, true);
            WriteLiteral("\r\n                                    </li>\r\n                                </ul>\r\n                            </div>\r\n                        </div>\r\n                        <h3 class=\"my-text\">");
            EndContext();
            BeginContext(5941, 9, false);
#line 113 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Company\List.cshtml"
                                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5950, 59, true);
            WriteLiteral("</h3>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 116 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Company\List.cshtml"
            }

#line default
#line hidden
            BeginContext(6024, 1417, true);
            WriteLiteral(@"            <div class=""col-xl-3 d-none"" id=""divCompany"">
                <div class=""profile-widget"">
                    <div class=""dropdown profile-action"">
                        <a class=""action-icon dropdown-toggle"" data-toggle=""dropdown"" aria-expanded=""false""></a>
                        <div class=""dropdown-menu departament dropdown-menu-right"">
                            <ul class=""action departament"">
                                <li>
                                    <a title=""Edit"" class=""btn bg-color""><i class=""fas fa-pen""></i></a>
                                </li>
                                <li>
                                    <button title=""Delete"" class=""bg-color btn text-white companyDelete"">
                                        <i class=""fas fa-trash""></i>
                                    </button>
                                </li>
                                <li>
                                    <a title=""Details"" class=""bg-color btn text");
            WriteLiteral(@"-white"">
                                        <i class=""fas fa-info-circle""></i>
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <h3 class=""my-text""></h3>
                </div>
            </div>
        </div>

    </div>
</div>

");
            EndContext();
            BeginContext(7495, 617, true);
            WriteLiteral(@"
<div class=""modal fade"" id=""companyDelete"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""delete-up""></div>
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>
            <h5 class=""text-center pt-4 bold"">Şirkət: ""<span id=""companyDeleteName""></span>""</h5>
            <h6 class=""ml-5 text-center py-2 text-danger bold"">Silmək isdədiyinizdən əminsinizmi ?</h6>
            <div class=""modal-footer"">
                <span class=""AntiForge""> ");
            EndContext();
            BeginContext(8113, 23, false);
#line 159 "C:\Users\Turan\Desktop\12\FinalProject\Areas\PayrollAdmin\Views\Company\List.cshtml"
                                    Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(8136, 377, true);
            WriteLiteral(@" </span>
                <button type=""button"" class=""btn companyDeleteSave bg-danger text-white"" data-dismiss=""modal"">
                    <i class=""fas fa-trash""></i>
                    <span class=""caption-subject bold ml-2"">
                        Sil
                    </span>
                </button>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompanyPaginationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
