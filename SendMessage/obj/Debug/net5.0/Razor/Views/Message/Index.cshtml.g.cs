#pragma checksum "C:\Users\Administrator\Desktop\ASP. NET MVC  DERSLERİ\SendMessage\SendMessage\Views\Message\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7f5cd6d4d67689ef472581dfc82c822eac0cfb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_Index), @"mvc.1.0.view", @"/Views/Message/Index.cshtml")]
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
#line 1 "C:\Users\Administrator\Desktop\ASP. NET MVC  DERSLERİ\SendMessage\SendMessage\Views\_ViewImports.cshtml"
using SendMessage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\ASP. NET MVC  DERSLERİ\SendMessage\SendMessage\Views\_ViewImports.cshtml"
using SendMessage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7f5cd6d4d67689ef472581dfc82c822eac0cfb8", @"/Views/Message/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31f701351a755f44bd084cd06ac863718809d214", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Message_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\ASP. NET MVC  DERSLERİ\SendMessage\SendMessage\Views\Message\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7f5cd6d4d67689ef472581dfc82c822eac0cfb83594", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">

    <!--  All snippets are MIT license http://bootdey.com/license -->
    <title>Mesaj Listeleme unsalgel.com</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <script src=""https://code.jquery.com/jquery-1.10.2.min.js""></script>
    <link href=""https://netdna.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css"" rel=""stylesheet"">
    <script src=""https://netdna.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7f5cd6d4d67689ef472581dfc82c822eac0cfb85074", async() => {
                WriteLiteral(@"
    <link href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css"" rel=""stylesheet"">
    <div class=""container"">
        <div class=""be-comment-block"">
            <h1 class=""comments-title"">Yorumlar</h1>
            <div class=""be-comment"" id=""listcom"" >
                <!--Yorumlar burda listelenecek-->
            </div>
           
                <div class=""row"">
                    <div class=""col-xs-12 col-sm-6"">
                        <div class=""form-group fl_icon"">
                            <div class=""icon""><i class=""fa fa-user""></i></div>
                            <input class=""form-input"" id=""Name"" type=""text"" placeholder=""İsim Soyisim"">
                        </div>
                    </div>
                    <div class=""col-xs-12 col-sm-6 fl_icon"">
                        <div class=""form-group fl_icon"">
                            <div class=""icon""><i class=""fa fa-envelope-o""></i></div>
                            <input class=""form-input");
                WriteLiteral(@""" id=""Mail"" type=""text"" placeholder=""Mail"">
                        </div>
                    </div>
                    <div class=""col-xs-12"">
                        <div class=""form-group"">
                            <textarea class=""form-input"" id=""MessageContent""");
                BeginWriteAttribute("required", " required=\"", 1888, "\"", 1899, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""içerik""></textarea>
                        </div>
                    </div>
                    <div class=""col-xs-12"">
                        <div class=""form-group"">
                            <input class=""form-input"" hidden id=""Date""");
                BeginWriteAttribute("value", " value=\"", 2160, "\"", 2181, 1);
#nullable restore
#line 46 "C:\Users\Administrator\Desktop\ASP. NET MVC  DERSLERİ\SendMessage\SendMessage\Views\Message\Index.cshtml"
WriteAttributeValue("", 2168, DateTime.Now, 2168, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 2182, "\"", 2193, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"içerik\">\r\n                        </div>\r\n                    </div>\r\n                    <button id=\"btnadd\" class=\"btn btn-primary pull-right\">Gönder</button>\r\n");
                WriteLiteral(@"                </div>
        </div>
    </div>

    <style type=""text/css"">
        body {
            margin-top: 20px;
            background-color: #e9ebee;
        }

        .be-comment-block {
            margin-bottom: 50px !important;
            border: 1px solid #edeff2;
            border-radius: 2px;
            padding: 50px 70px;
            border: 1px solid #ffffff;
        }

        .comments-title {
            font-size: 16px;
            color: #262626;
            margin-bottom: 15px;
            font-family: 'Conv_helveticaneuecyr-bold';
        }

        .be-img-comment {
            width: 60px;
            height: 60px;
            float: left;
            margin-bottom: 15px;
        }

        .be-ava-comment {
            width: 60px;
            height: 60px;
            border-radius: 50%;
        }

        .be-comment-content {
            margin-left: 80px;
        }

            .be-comment-content span {
                display:");
                WriteLiteral(@" inline-block;
                width: 49%;
                margin-bottom: 15px;
            }

        .be-comment-name {
            font-size: 13px;
            font-family: 'Conv_helveticaneuecyr-bold';
        }

        .be-comment-content a {
            color: #383b43;
        }

        .be-comment-content span {
            display: inline-block;
            width: 49%;
            margin-bottom: 15px;
        }

        .be-comment-time {
            text-align: right;
        }

        .be-comment-time {
            font-size: 11px;
            color: #b4b7c1;
        }

        .be-comment-text {
            font-size: 13px;
            line-height: 18px;
            color: #7a8192;
            display: block;
            background: #f6f6f7;
            border: 1px solid #edeff2;
            padding: 15px 20px 20px 20px;
        }

        .form-group.fl_icon .icon {
            position: absolute;
            top: 1px;
            left: 16px;
         ");
                WriteLiteral(@"   width: 48px;
            height: 48px;
            background: #f6f6f7;
            color: #b5b8c2;
            text-align: center;
            line-height: 50px;
            -webkit-border-top-left-radius: 2px;
            -webkit-border-bottom-left-radius: 2px;
            -moz-border-radius-topleft: 2px;
            -moz-border-radius-bottomleft: 2px;
            border-top-left-radius: 2px;
            border-bottom-left-radius: 2px;
        }

        .form-group .form-input {
            font-size: 13px;
            line-height: 50px;
            font-weight: 400;
            color: #b4b7c1;
            width: 100%;
            height: 50px;
            padding-left: 20px;
            padding-right: 20px;
            border: 1px solid #edeff2;
            border-radius: 3px;
        }

        .form-group.fl_icon .form-input {
            padding-left: 70px;
        }

        .form-group textarea.form-input {
            height: 150px;
        }
    </style>

    ");
                WriteLiteral(@"<script type=""text/javascript"">
        //Yorum Listeleme
        $(document).ready(function () {
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Message/GetList/"",
                success: function (funk) {
                    let values = jQuery.parseJSON(funk);
                    let htmlst = ``;
                    $.each(values, (index, value) => {
                        htmlst += `<div class=""be-img-comment""> <a href=""blog-detail-2.html""> <img src=""https://bootdey.com/img/Content/avatar/avatar3.png"" alt="""" class=""be-ava-comment""> </a> </div> <div class=""be-comment-content""> <span class=""be-comment-name""> <a href=""blog-detail-2.html"">${value.Name}</a> </span> <span class=""be-comment-time""> <i class=""fa fa-clock-o""></i> ${value.Date} </span> <p class=""be-comment-text""> ${value.MessageContent} </p> </div>`;
                    });

                    $(""#listcom"").html(htmlst);
   ");
                WriteLiteral(@"             }
            });
        });


     // Yorum Gönderme
        $(""#btnadd"").click(function () {
            let values = {
                Name: $(""#Name"").val(),
                MessageContent: $(""#MessageContent"").val(),
                Mail: $(""#Mail"").val(),
                Date: $(""#Date"").val()
            };
            $.ajax({
                type: ""Post"",
                url: ""/Message/MessageAdd/"",
                data: values,
                success: function (fnk1) {
                    let valueat = jQuery.parseJSON(fnk1);
                    let htmlstr = ``;
                    // console.log(fnk1);
                    htmlstr = `<div class=""be-img-comment""> <a href=""blog-detail-2.html""> <img src=""https://bootdey.com/img/Content/avatar/avatar3.png"" alt="""" class=""be-ava-comment""> </a> </div> <div class=""be-comment-content""> <span class=""be-comment-name""> <a href=""blog-detail-2.html"">${valueat.Name}</a> </span> <span class=""be-comment-time""> <i class=""fa fa-clo");
                WriteLiteral(@"ck-o""></i> ${valueat.Date} </span> <p class=""be-comment-text""> ${valueat.MessageContent} </p> </div>`;
                    $(""#listcom"").append(htmlstr);
                     
                }
            });
        });
    </script>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
