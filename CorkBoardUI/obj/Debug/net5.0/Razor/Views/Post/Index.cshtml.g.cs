#pragma checksum "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45431762bf74ad11995c609b78ee9f8e86806174"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Index), @"mvc.1.0.view", @"/Views/Post/Index.cshtml")]
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
#line 1 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\_ViewImports.cshtml"
using CorkBoardUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\_ViewImports.cshtml"
using CorkBoardUI.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45431762bf74ad11995c609b78ee9f8e86806174", @"/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"977f12720aff1e491a5cec67a59b8bba8f711f02", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CorkBoardUI.ViewModels.PostViewModels.PostViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("reply-btn btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
  
    Layout = "_HomeLayout";
    ViewData["HeaderImage"] = $"../../UserFiles/Posts/{Model.Post.Id}/HeaderImage.jpg";
    ViewData["LeftSideImage"] = $"../../UserFiles/Posts/{Model.Post.Id}/LeftSideImage.jpg";
    ViewData["HeaderTitle"] = Model.Post.Title;
    ViewData["AuthorName"] = $"{Model.Post.Creator.FirstName}{Model.Post.Creator.LastName}";
    ViewData["PostDate"] = Model.Post.UpdatedOn.ToString("MMMM d,yyyy");
    ViewData["AuthorId"] = Model.Post.Creator.Id;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<article>\r\n    <div>\r\n        <img class=\"left-side-image\"");
            BeginWriteAttribute("src", " src=\"", 606, "\"", 638, 1);
#nullable restore
#line 14 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
WriteAttributeValue("", 612, ViewData["LeftSideImage"], 612, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-15 col-md-10 mx-auto\">\r\n                ");
#nullable restore
#line 17 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
           Write(Html.Raw(Model.Post.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row mt-5\">\r\n            <div class=\"col-lg-15 col-md-10 mx-auto\">\r\n                <h3 class=\"mb-5\">");
#nullable restore
#line 22 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
                            Write(Model.Post.Comments.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" Comment(s)</h3>\r\n                <ul class=\"comment-list comment-top\"");
            BeginWriteAttribute("list", " list=\"", 1048, "\"", 1075, 1);
#nullable restore
#line 23 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
WriteAttributeValue("", 1055, Model.Post.Comments, 1055, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" count=\"0\">\r\n");
#nullable restore
#line 24 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
                     foreach (var comment in Model.Post.Comments.Where(comment => comment.Parent is null))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"comment\" style=\"margin-top: 30px;\">\r\n                            <div class=\"comment-body\">\r\n                                <h4 class=\"commenter-name\">");
#nullable restore
#line 28 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
                                                      Write(comment.Author.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 28 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
                                                                                Write(comment.Author.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <div class=\"comment-date\">");
#nullable restore
#line 29 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
                                                     Write(comment.CreatedOn.ToString("MMMM d, yyyy hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <p class=\"comment-message\">");
#nullable restore
#line 30 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
                                                      Write(comment.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 31 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
                                 if (!User.Identity.IsAuthenticated)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45431762bf74ad11995c609b78ee9f8e8680617410927", async() => {
                WriteLiteral("Login to reply");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ReturnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/Post/");
#nullable restore
#line 33 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
                                                                                                                           WriteLiteral(Model.Post.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ReturnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ReturnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ReturnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 34 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a aria-expanded=\"false\"");
            BeginWriteAttribute("href", " href=\"", 2107, "\"", 2145, 1);
#nullable restore
#line 37 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
WriteAttributeValue("", 2114, $"#replyComment(comment.Id)", 2114, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"collapse\" class=\"reply-btn btn\">Reply</a>\r\n");
#nullable restore
#line 38 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n");
#nullable restore
#line 40 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
                             if (User.Identity.IsAuthenticated)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 2423, "\"", 2458, 1);
#nullable restore
#line 42 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
WriteAttributeValue("", 2428, $"replyComment{comment.Id}", 2428, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45431762bf74ad11995c609b78ee9f8e8680617415561", async() => {
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45431762bf74ad11995c609b78ee9f8e8680617415860", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 44 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Post.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45431762bf74ad11995c609b78ee9f8e8680617418066", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 45 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Comment.Parent.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
                                                                      WriteLiteral(comment.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        <div class=\"form-group\">\r\n                                            <label for=\"comment\">Write a reply.</label>\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45431762bf74ad11995c609b78ee9f8e8680617421198", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 48 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Comment.Content);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            <button type=\"submit\" class=\"btn btn-outline-primary post-btn\">Post</button>\r\n                                        </div>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 53 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <ul class=\"comment-list\"");
            BeginWriteAttribute("list", " list=\"", 3365, "\"", 3389, 1);
#nullable restore
#line 54 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
WriteAttributeValue("", 3372, comment.Comments, 3372, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" count=\"0\" style=\"margin-left: 30px; margin-top:0;\">\r\n");
#nullable restore
#line 55 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
                                 foreach (var reply in comment.Comments)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"comment\">\r\n                                        <div class=\"comment-body\">\r\n                                            <h3 class=\"commenter-name\">");
#nullable restore
#line 59 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
                                                                  Write(reply.Author.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 59 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
                                                                                          Write(reply.Author.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                            <div class=\"comment-date\">");
#nullable restore
#line 60 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
                                                                 Write(reply.CreatedOn.ToString("MMMM d, yyyy hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                            <p class=\"comment-message\">");
#nullable restore
#line 61 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
                                                                  Write(reply.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </li>\r\n");
#nullable restore
#line 64 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </li>\r\n                        <hr />\r\n");
#nullable restore
#line 68 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n");
#nullable restore
#line 70 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45431762bf74ad11995c609b78ee9f8e8680617428478", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45431762bf74ad11995c609b78ee9f8e8680617428765", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 74 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Post.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                <label for=\"comment\">Comment</label>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45431762bf74ad11995c609b78ee9f8e8680617431095", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 77 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Comment.Content);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <button type=\"submit\" class=\"btn btn-outline-primary post-btn\">Post</button>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 82 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45431762bf74ad11995c609b78ee9f8e8680617435038", async() => {
                WriteLiteral("Login to Comment on this Post");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ReturnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/Post/");
#nullable restore
#line 85 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
                                                                                                           WriteLiteral(Model.Post.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ReturnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ReturnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ReturnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 86 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Post\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</article>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $('[data-toggle=""collapse""]').on('click', function () {
            var=$this = $(this),
                $parent = typeof $this.data('parent') !== 'undefined' ? $($this.data('parent')) : undefined;
            if ($parent === undefined) {
                $this.find('.glyphicon').toggleClass('glyphicon-plus glyphicon-minus');
                return true;
            }

            var currentIcon = $this.find('.glyphicon');
            currentIcon.toggleClass('glyphicon-plus glyphicon-minus');
            $parent.find('.glyphicon').not(currentIcon).removeClass('glyphicon-minus').addClass('glyphicon-plus');
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CorkBoardUI.ViewModels.PostViewModels.PostViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
