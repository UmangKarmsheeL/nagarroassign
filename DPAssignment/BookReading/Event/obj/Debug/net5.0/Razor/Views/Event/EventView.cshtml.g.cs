#pragma checksum "C:\Users\umangkarmsheel\Desktop\umang-karmsheel\DPAssignment\BookReading\Event\Views\Event\EventView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4b4616e08f1bef30f77cfe7e2aaed7dd6cb32b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_EventView), @"mvc.1.0.view", @"/Views/Event/EventView.cshtml")]
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
#line 1 "C:\Users\umangkarmsheel\Desktop\umang-karmsheel\DPAssignment\BookReading\Event\Views\_ViewImports.cshtml"
using Event;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\umangkarmsheel\Desktop\umang-karmsheel\DPAssignment\BookReading\Event\Views\_ViewImports.cshtml"
using Event.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\umangkarmsheel\Desktop\umang-karmsheel\DPAssignment\BookReading\Event\Views\Event\EventView.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4b4616e08f1bef30f77cfe7e2aaed7dd6cb32b9", @"/Views/Event/EventView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea99ecf72765b45f757428527b749f4789efc772", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_EventView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Event.Models.ViewModels.EditEventViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("comment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EventComments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-circle text-uppercase"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\umangkarmsheel\Desktop\umang-karmsheel\DPAssignment\BookReading\Event\Views\Event\EventView.cshtml"
  
    var user = await _userManager.GetUserAsync(User);
    var Name = user != null ? user.UserName : "";

   

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container py-5\">\r\n\r\n");
#nullable restore
#line 16 "C:\Users\umangkarmsheel\Desktop\umang-karmsheel\DPAssignment\BookReading\Event\Views\Event\EventView.cshtml"
     if (Model != null)
    {

        String[] Invitees = @Model.InviteByEmail.Split(",");

        int Count = Invitees.Length;



        

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"mb-3\">\r\n            <p class=\"text-success d-inline\">Title :</p>");
#nullable restore
#line 26 "C:\Users\umangkarmsheel\Desktop\umang-karmsheel\DPAssignment\BookReading\Event\Views\Event\EventView.cshtml"
                                                   Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"mb-3\">\r\n            <p class=\"text-success d-inline\">Date :</p>");
#nullable restore
#line 29 "C:\Users\umangkarmsheel\Desktop\umang-karmsheel\DPAssignment\BookReading\Event\Views\Event\EventView.cshtml"
                                                  Write(Model.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"mb-3\">\r\n            <p class=\"text-success d-inline\">Location :</p>");
#nullable restore
#line 32 "C:\Users\umangkarmsheel\Desktop\umang-karmsheel\DPAssignment\BookReading\Event\Views\Event\EventView.cshtml"
                                                      Write(Model.location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"mb-3\">\r\n            <p class=\"text-success d-inline\">Start Time :</p>");
#nullable restore
#line 35 "C:\Users\umangkarmsheel\Desktop\umang-karmsheel\DPAssignment\BookReading\Event\Views\Event\EventView.cshtml"
                                                        Write(Model.startTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"mb-3\">\r\n            <p class=\"text-success d-inline\">Duration In Hours :</p>");
#nullable restore
#line 40 "C:\Users\umangkarmsheel\Desktop\umang-karmsheel\DPAssignment\BookReading\Event\Views\Event\EventView.cshtml"
                                                               Write(Model.durationInHours);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"mb-3\">\r\n            <p class=\"text-success d-inline\">Description :</p>");
#nullable restore
#line 43 "C:\Users\umangkarmsheel\Desktop\umang-karmsheel\DPAssignment\BookReading\Event\Views\Event\EventView.cshtml"
                                                         Write(Model.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"mb-3\">\r\n            <p class=\"text-success d-inline\">Other Details :</p>");
#nullable restore
#line 46 "C:\Users\umangkarmsheel\Desktop\umang-karmsheel\DPAssignment\BookReading\Event\Views\Event\EventView.cshtml"
                                                           Write(Model.otherDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"mb-3\">\r\n            <p class=\"text-success d-inline\">Invitees :</p>");
#nullable restore
#line 49 "C:\Users\umangkarmsheel\Desktop\umang-karmsheel\DPAssignment\BookReading\Event\Views\Event\EventView.cshtml"
                                                      Write(Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <div class=\" mb-3\">\r\n            <p class=\"text-success d-inline\">Is Public :</p>");
#nullable restore
#line 53 "C:\Users\umangkarmsheel\Desktop\umang-karmsheel\DPAssignment\BookReading\Event\Views\Event\EventView.cshtml"
                                                       Write(Model.Visible);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"mb-3\">\r\n            <p class=\"text-success d-inline\">Organiser :</p>");
#nullable restore
#line 56 "C:\Users\umangkarmsheel\Desktop\umang-karmsheel\DPAssignment\BookReading\Event\Views\Event\EventView.cshtml"
                                                       Write(Model.Organiser);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("        <hr style=\"height:2px; width:80%; border-width:0; color:black; background-color:black\">\r\n        <div class=\"container\">\r\n            <div class=\"col-md-12\" align=\"center\" style=\"width: 50%;\">\r\n");
#nullable restore
#line 62 "C:\Users\umangkarmsheel\Desktop\umang-karmsheel\DPAssignment\BookReading\Event\Views\Event\EventView.cshtml"
                 using (Html.BeginForm("PostComment", "Comment"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""form-group"">
                        <div class=""row"">
                            <div class=""col-sm-3"">

                                <img src=""https://image.ibb.co/jw55Ex/def_face.jpg"" class=""img img-rounded img-fluid"" />
                                <p>
                                    <a class=""float-left""");
            BeginWriteAttribute("href", " href=\"", 2358, "\"", 2365, 0);
            EndWriteAttribute();
            WriteLiteral("><strong class=\"text-success\">Anonymous</strong></a>\r\n                                </p>\r\n                            </div>\r\n\r\n                            <div class=\"col-sm-9\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4b4616e08f1bef30f77cfe7e2aaed7dd6cb32b912133", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 75 "C:\Users\umangkarmsheel\Desktop\umang-karmsheel\DPAssignment\BookReading\Event\Views\Event\EventView.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CommentDescription);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <div class=\"col-sm-offset-2 col-sm-10\">\r\n                            ");
#nullable restore
#line 82 "C:\Users\umangkarmsheel\Desktop\umang-karmsheel\DPAssignment\BookReading\Event\Views\Event\EventView.cshtml"
                       Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            <button class=""btn btn-success btn-circle text-uppercase"" type=""submit"" value=""Post"" id=""submitComment""><span class=""glyphicon glyphicon-send""></span> Post comment</button>
                        </div>
                    </div>
");
#nullable restore
#line 86 "C:\Users\umangkarmsheel\Desktop\umang-karmsheel\DPAssignment\BookReading\Event\Views\Event\EventView.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n");
            WriteLiteral("        <hr style=\"height:2px; width:80%; border-width:0; color:black; background-color:black\">\r\n        <div class=\"btn-group mt-2 col-sm-offset-2 col-sm-10\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4b4616e08f1bef30f77cfe7e2aaed7dd6cb32b915175", async() => {
                WriteLiteral("Show Comments");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "C:\Users\umangkarmsheel\Desktop\umang-karmsheel\DPAssignment\BookReading\Event\Views\Event\EventView.cshtml"
                                                                                 WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 95 "C:\Users\umangkarmsheel\Desktop\umang-karmsheel\DPAssignment\BookReading\Event\Views\Event\EventView.cshtml"


    }

    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No Event Found</p>\r\n");
#nullable restore
#line 102 "C:\Users\umangkarmsheel\Desktop\umang-karmsheel\DPAssignment\BookReading\Event\Views\Event\EventView.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> _userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> _signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Event.Models.ViewModels.EditEventViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
