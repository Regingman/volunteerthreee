#pragma checksum "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e004b0ec2ccbcb96f87446b44aabd0f65290d585"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Volunteers_Index), @"mvc.1.0.view", @"/Views/Volunteers/Index.cshtml")]
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
#line 1 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\_ViewImports.cshtml"
using VolunteerThree;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\_ViewImports.cshtml"
using VolunteerThree.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e004b0ec2ccbcb96f87446b44aabd0f65290d585", @"/Views/Volunteers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ed517236384eae1e04b3e3ddb06566c9739b5b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Volunteers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VolunteerThree.Models.Volunteer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.5.2/css/bootstrap.css"" />
<link rel=""stylesheet"" href=""https://cdn.datatables.net/1.10.22/css/jquery.dataTables.min.css"" />
<link rel=""stylesheet"" href=""https://cdn.datatables.net/buttons/1.6.4/css/buttons.dataTables.min.css"" />



<h1>Волонтёры</h1>

");
#nullable restore
#line 15 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"

<style media=""screen"">
    tfoot input {
        width: 100%;
        padding: 3px;
        box-sizing: border-box;
    }

    /*#example_next {
        background-color: #4CAF50;
        border: none;
        color: white;
        padding: 15px 32px;
        text-align: center;
        text-decoration: none;
        display: inline-block;
        font-size: 9px;
    }

        #example_next:hover {
            background-color: #1b571e;
            border: none;
            color: white;
            padding: 15px 32px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 9px;
            cursor: pointer;
        }


    #example_previous {
        background-color: #4CAF50;
        border: none;
        color: white;
        padding: 15px 32px;
        text-align: center;
        text-decoration: none;
        display: inline-block;
        font-size: 9px;
    }

        #example_previous:hov");
            WriteLiteral(@"er {
            background-color: #1b571e;
            border: none;
            color: white;
            padding: 15px 32px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 9px;
            cursor: pointer;
        }*/

    .dt-button {
        background-color: #696060;
        border: none;
        color: white;
        padding: 5px 32px;
        text-align: center;
        text-decoration: none;
        display: inline-block;
        font-size: 12px;
        margin-bottom: 5px;
    }

    th, td {
        text-align: left;
        padding: 2px;
    }

    th {
        background-color: #418b9f;
        color: white;
    }
</style>
<div class=""overflow-auto"">
    <table id=""example""
           ");
            WriteLiteral("           class=\"display nowrap table table-bordered\" style=\"width:100%\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 132 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.VSurname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 135 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.VName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 138 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.VBirthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 141 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.VPersonNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n\r\n                    ");
#nullable restore
#line 145 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ZonId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 148 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.VPhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 151 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Note));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n\r\n        <tfoot>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 160 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.VSurname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 163 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.VName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 166 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.VBirthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 169 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.VPersonNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n\r\n                    ");
#nullable restore
#line 173 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ZonId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 176 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.VPhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 179 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Note));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </tfoot>\r\n\r\n        <tbody>\r\n");
#nullable restore
#line 186 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 190 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.VSurname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 193 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.VName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 196 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.VBirthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 199 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.VPersonNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 202 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Zon.ZName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 205 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.VPhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 208 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Note));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e004b0ec2ccbcb96f87446b44aabd0f65290d58515021", async() => {
                WriteLiteral("Удалить");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 213 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
                                                 WriteLiteral(item.VId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 216 "E:\programming\project\ProjectGit\Socservice_Git_Lab\volunteerthreee\VolunteerThree\Views\Volunteers\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n\r\n    </table>\r\n</div>\r\n\r\n\r\n");
            WriteLiteral("<script src=\"https://code.jquery.com/jquery-3.5.1.js\" charset=\"utf-8\"></script>\r\n");
            WriteLiteral(@"<script src=""https://cdn.datatables.net/1.10.22/js/jquery.dataTables.min.js"" charset=""utf-8""></script>
<script src=""https://cdn.datatables.net/buttons/1.6.4/js/dataTables.buttons.min.js"" charset=""utf-8""></script>
<script src=""https://cdn.datatables.net/buttons/1.6.4/js/buttons.flash.min.js"" charset=""utf-8""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jszip/3.1.3/jszip.min.js"" charset=""utf-8""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/pdfmake.min.js"" charset=""utf-8""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/vfs_fonts.js"" charset=""utf-8""></script>
<script src=""https://cdn.datatables.net/buttons/1.6.4/js/buttons.html5.min.js"" charset=""utf-8""></script>
<script src=""https://cdn.datatables.net/buttons/1.6.4/js/buttons.print.min.js"" charset=""utf-8""></script>
<script src=""https://cdn.datatables.net/plug-ins/1.10.21/i18n/Russian.json"" charset=""utf-8""></script>



<script type=""text/javascript"">
    $(document).ready(func");
            WriteLiteral(@"tion () {
        // Setup - add a text input to each footer cell
        $('#example tfoot th').each(function () {
            var title = $(this).text();
            $(this).html('<input type=""text"" placeholder=""Поиск"" />');
        });


        // DataTable
        var table = $('#example').DataTable({
            initComplete: function () {
                // Apply the search
                this.api().columns().every(function () {
                    var that = this;

                    $('input', this.footer()).on('keyup change clear', function () {
                        if (that.search() !== this.value) {
                            that
                                .search(this.value)
                                .draw();
                        }
                    });

                });
            },
            dom: 'Bfrtip',
            buttons: [
                'copy', 'excel', 'pdf', 'print'
            ],
        });
        $('#example tfoot tr').ap");
            WriteLiteral("pendTo(\'#example thead\');\r\n\r\n\r\n    });\r\n\r\n</script>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n    <!--JQuery-->\r\n");
                WriteLiteral("\r\n");
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VolunteerThree.Models.Volunteer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
