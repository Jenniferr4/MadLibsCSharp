#pragma checksum "C:\source\MadLibsCSharp\MadLibsCSharp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "967423c9f4b343bed9ad719cf3683f68517e51bc"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"967423c9f4b343bed9ad719cf3683f68517e51bc", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\source\MadLibsCSharp\MadLibsCSharp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <br />
    <h2>Fill in the fields to create a MadLib!</h2><br />

    <form action=""/Body"" method=""post"">

        <input id=""Adjective"" name=""Adjective"" type=""text"" placeholder=""Adjective""><br /><br />
        <input id=""Verbing1"" name=""Verbing1"" type=""text"" placeholder=""Verb Ending in -ing""><br /><br />
        <input id=""BookChar1"" name=""BookChar1"" type=""text"" placeholder=""Book Character""><br /><br />
        <input id=""Verbing2"" name=""Verbing2"" type=""text"" placeholder=""Verb Ending in -ing""><br /><br />
        <input id=""BookChar2"" name=""BookChar2"" type=""text"" placeholder=""Another Book Character""><br /><br />
        <input id=""HomeT"" name=""HomeT"" type=""text"" placeholder=""Home Town""><br /><br />
        <input id=""BookChar3"" name=""BookChar3"" type=""text"" placeholder=""Another Book Character""><br /><br />
        <input id=""Title"" name=""Title"" type=""text"" placeholder=""Title""><br /><br />
        <input id=""Name1"" name=""Name1"" type=""text"" placeholder=""Name""><br />");
            WriteLiteral(@"<br />
        <input id=""State"" name=""State"" type=""text"" placeholder=""State""><br /><br />
        <input id=""Name2"" name=""Name12"" type=""text"" placeholder=""Another Name""><br /><br />
        <input id=""Onomonopia"" name=""Onomonopia"" type=""text"" placeholder=""Onomonopia""><br /><br />
        <input id=""PastVerb"" name=""PastVerb"" type=""text"" placeholder=""Past Tense Verb""><br /><br />
        <input id=""Number"" name=""Number"" type=""text"" placeholder=""Number 1-6""><br /><br />
        <br />
        <button type=""submit"">Go!</button><br />
    </form>


</div>
<!--
     public string Adjective { get; set; }
        public string Verb_ing1 { get; set; }
        public string BookChar1 { get; set; }
        public string Verb_ing2 { get; set; }
        public string BookChar2 { get; set; }
        public string HomeTown { get; set; }
        public string BookChar3 { get; set; }
        public string Title { get; set; }
        public string Name1 { get; set; }
        public string State { get; se");
            WriteLiteral("t; }\r\n        public string Name2 { get; set; }\r\n        public string Onomonopia { get; set; }\r\n        public string PastVerb { get; set; }\r\n        public int Number { get; set; }\r\n\r\n    number between 1&6\r\n    -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
