#pragma checksum "C:\Users\Aniket\Documents\GitHub\Pencil\Pencil\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b57fb5d2557efb4fc2d282e7469132c81e6d0d94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Aniket\Documents\GitHub\Pencil\Pencil\Views\_ViewImports.cshtml"
using Pencil;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aniket\Documents\GitHub\Pencil\Pencil\Views\_ViewImports.cshtml"
using Pencil.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b57fb5d2557efb4fc2d282e7469132c81e6d0d94", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0a5153a2f7038c08d79864e44b8a42af2a7cc98", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pencil.Models.Db.PencilTable>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Aniket\Documents\GitHub\Pencil\Pencil\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a");
            BeginWriteAttribute("href", " href=\'", 95, "\'", 139, 1);
#nullable restore
#line 7 "C:\Users\Aniket\Documents\GitHub\Pencil\Pencil\Views\Home\Index.cshtml"
WriteAttributeValue("", 102, Url.Action("Create", "InsertUpdate"), 102, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Create Pencil</a>
<br />

<br />

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Pencil Name</th>
            <th scope=""col"">Price</th>
            <th scope=""col"">Image</th>
            <th scope=""col"">edit link</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 23 "C:\Users\Aniket\Documents\GitHub\Pencil\Pencil\Views\Home\Index.cshtml"
         foreach (var pencil in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\Aniket\Documents\GitHub\Pencil\Pencil\Views\Home\Index.cshtml"
               Write(pencil.PencilId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\'", 612, "\'", 678, 1);
#nullable restore
#line 27 "C:\Users\Aniket\Documents\GitHub\Pencil\Pencil\Views\Home\Index.cshtml"
WriteAttributeValue("", 619, Url.Action("Product","Home", new { id = pencil.PencilId }), 619, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "C:\Users\Aniket\Documents\GitHub\Pencil\Pencil\Views\Home\Index.cshtml"
                                                                                     Write(pencil.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                <td class=\"row\">\r\n                    ");
#nullable restore
#line 29 "C:\Users\Aniket\Documents\GitHub\Pencil\Pencil\Views\Home\Index.cshtml"
               Write(pencil.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 32 "C:\Users\Aniket\Documents\GitHub\Pencil\Pencil\Views\Home\Index.cshtml"
                     if (pencil.Image != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 914, "\"", 980, 1);
#nullable restore
#line 34 "C:\Users\Aniket\Documents\GitHub\Pencil\Pencil\Views\Home\Index.cshtml"
WriteAttributeValue("", 921, Url.Action("Product","Home", new { id = pencil.PencilId }), 921, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 986, "\"", 1054, 2);
            WriteAttributeValue("", 992, "data:image;base64,", 992, 18, true);
#nullable restore
#line 34 "C:\Users\Aniket\Documents\GitHub\Pencil\Pencil\Views\Home\Index.cshtml"
WriteAttributeValue("", 1010, System.Convert.ToBase64String(pencil.Image), 1010, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"40\" height=\"40\" /> </a>\r\n");
#nullable restore
#line 35 "C:\Users\Aniket\Documents\GitHub\Pencil\Pencil\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td class=\"row\"><a");
            BeginWriteAttribute("href", " href=\'", 1168, "\'", 1240, 1);
#nullable restore
#line 37 "C:\Users\Aniket\Documents\GitHub\Pencil\Pencil\Views\Home\Index.cshtml"
WriteAttributeValue("", 1175, Url.Action("Edit", "InsertUpdate", new { id = pencil.PencilId }), 1175, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit Link</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Aniket\Documents\GitHub\Pencil\Pencil\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pencil.Models.Db.PencilTable>> Html { get; private set; }
    }
}
#pragma warning restore 1591
