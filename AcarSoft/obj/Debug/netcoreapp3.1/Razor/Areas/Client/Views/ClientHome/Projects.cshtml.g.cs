#pragma checksum "C:\Users\Ozan\Desktop\AcarSoft\AcarSoft\Areas\Client\Views\ClientHome\Projects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ac598787f4b1865f938f16705a368989d157d0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Client_Views_ClientHome_Projects), @"mvc.1.0.view", @"/Areas/Client/Views/ClientHome/Projects.cshtml")]
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
#line 5 "C:\Users\Ozan\Desktop\AcarSoft\AcarSoft\Areas\Client\Views\ClientHome\Projects.cshtml"
using Model.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ac598787f4b1865f938f16705a368989d157d0e", @"/Areas/Client/Views/ClientHome/Projects.cshtml")]
    #nullable restore
    public class Areas_Client_Views_ClientHome_Projects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
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
#line 1 "C:\Users\Ozan\Desktop\AcarSoft\AcarSoft\Areas\Client\Views\ClientHome\Projects.cshtml"
  
    Layout = "~/Areas/Client/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"tr\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ac598787f4b1865f938f16705a368989d157d0e3323", async() => {
                WriteLiteral(@"

    <!--  Meta  -->
    <meta charset=""UTF-8"" />
    <title>Products</title>

    <!--  Styles  -->
    <link href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""styles/index.processed.css"">

    <!-- Fonts -->
    <link href='//fonts.googleapis.com/css?family=Roboto:400,300,100,700,500' rel='stylesheet' type='text/css'>
    <link href='//fonts.googleapis.com/css?family=Lato:300,400,700' rel='stylesheet' type='text/css'>
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"">
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js""></script>

    <style>
        body {
            background: #f6f6f6;
            font-family: Roboto;
        }

        .fm-page h2 {
            color: #0090d6;
            text-align");
                WriteLiteral(@": center;
        }

        .product-container {
            position: relative;
            padding: 15px;
            background: #fff;
        }

            .product-container .promo {
                width: 158px;
                height: 160px;
                position: absolute;
                top: 0;
                left: 0;
                background-image: url(""https://preprod.coriolis.com/media/wysiwyg/img/pages/fiche-produit-ab/bg-product-promo.png"");
                background-repeat: none;
            }

                .product-container .promo span {
                    display: inline-block;
                    margin: 5px;
                    font-size: 14px;
                    font-weight: 500;
                    text-align: center;
                    text-transform: uppercase;
                    color: #fff;
                }

            .product-container .product-title {
                margin-top: 30px;
            }

                .product-conta");
                WriteLiteral(@"iner .product-title h3 {
                    margin: 15px 0 15px 0;
                    text-align: center;
                    font-size: 22px;
                    color: #333;
                }

            .product-container .product-img img {
                display: block;
                margin-top: 30px;
                max-width: 190px;
                margin: 30px auto 0 auto;
            }

            .product-container .product-price {
                text-align: center;
                font-size: 27px;
                color: #0090d6;
            }

                .product-container .product-price span:first-child {
                    display: block;
                    margin: auto;
                    font-size: 12px;
                    font-weight: 500;
                    color: #333333;
                }

                .product-container .product-price .price {
                    display: block;
                    margin: auto;
                    font-si");
                WriteLiteral(@"ze: 27px;
                    font-weight: 500;
                }

                .product-container .product-price .old-price {
                    font-size: 12px;
                    color: #a1a1a1;
                }

            .product-container .product-button .button {
                display: block;
                width: 142px;
                max-width: 142px;
                margin: 15px auto;
                padding: 6px 10px;
                border-color: #c83d9c;
                border-radius: 2px !important;
                font-size: 16px;
                color: #fff;
                text-decoration: none;
                background: #c83d9c;
            }
            .filler{
                height: 200px;
            }


    </style>
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"" integrity=""sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u"" crossorigin=""anonymous"">

    <!-- JS -->");
                WriteLiteral(@"
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"" integrity=""sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa"" crossorigin=""anonymous""></script>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ac598787f4b1865f938f16705a368989d157d0e8864", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"container fm-page\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <h2");
                BeginWriteAttribute("class", " class=\"", 4694, "\"", 4702, 0);
                EndWriteAttribute();
                WriteLiteral(">Our Products</h2>\r\n            </div>\r\n        </div>\r\n    </div>\r\n        <div class=\"row\">\r\n\r\n");
#nullable restore
#line 143 "C:\Users\Ozan\Desktop\AcarSoft\AcarSoft\Areas\Client\Views\ClientHome\Projects.cshtml"
             foreach(var item in Model)
            {
                var PhotoPath = item.ProductName.Replace(" ", "") + ".jpg";
                var OldPrice = item.Price * 3;
                var NewPrice = item.Price * 2;

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"col-xs-12 col-md-3\">\r\n\r\n                    <div class=\"product-container\">\r\n\r\n                        <div class=\"product-img\">\r\n                            <img");
                BeginWriteAttribute("alt", " alt=\"", 5219, "\"", 5225, 0);
                EndWriteAttribute();
                BeginWriteAttribute("src", " src=\"", 5226, "\"", 5252, 2);
                WriteAttributeValue("", 5232, "/Pictures/", 5232, 10, true);
#nullable restore
#line 153 "C:\Users\Ozan\Desktop\AcarSoft\AcarSoft\Areas\Client\Views\ClientHome\Projects.cshtml"
WriteAttributeValue("", 5242, PhotoPath, 5242, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  />\r\n                        </div>\r\n                        <div class=\"product-title\">\r\n                            <h3>");
#nullable restore
#line 156 "C:\Users\Ozan\Desktop\AcarSoft\AcarSoft\Areas\Client\Views\ClientHome\Projects.cshtml"
                           Write(item.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br>");
#nullable restore
#line 156 "C:\Users\Ozan\Desktop\AcarSoft\AcarSoft\Areas\Client\Views\ClientHome\Projects.cshtml"
                                                Write(item.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Framework</h3>\r\n                        </div>\r\n                        <div class=\"product-price\">\r\n                            <span");
                BeginWriteAttribute("class", " class=\"", 5549, "\"", 5557, 0);
                EndWriteAttribute();
                WriteLiteral(">Monthly Subscription</span>\r\n                            <span class=\"price\">");
#nullable restore
#line 160 "C:\Users\Ozan\Desktop\AcarSoft\AcarSoft\Areas\Client\Views\ClientHome\Projects.cshtml"
                                           Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            <span class=\"old-price\"><s>");
#nullable restore
#line 161 "C:\Users\Ozan\Desktop\AcarSoft\AcarSoft\Areas\Client\Views\ClientHome\Projects.cshtml"
                                                  Write(OldPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(" €</s></span> <span class=\"old-price\">");
#nullable restore
#line 161 "C:\Users\Ozan\Desktop\AcarSoft\AcarSoft\Areas\Client\Views\ClientHome\Projects.cshtml"
                                                                                                 Write(NewPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(" € (Pay less)</span>\r\n                        </div>\r\n                        <div class=\"product-button\">\r\n                            <button type=\"button\" class=\"btn btn-primary buybutton\"");
                BeginWriteAttribute("ProId", " ProId=\"", 5958, "\"", 5974, 1);
#nullable restore
#line 164 "C:\Users\Ozan\Desktop\AcarSoft\AcarSoft\Areas\Client\Views\ClientHome\Projects.cshtml"
WriteAttributeValue("", 5966, item.Id, 5966, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" data-toggle=\"modal\" data-target=\"#myModal\">Buy Now!</button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 168 "C:\Users\Ozan\Desktop\AcarSoft\AcarSoft\Areas\Client\Views\ClientHome\Projects.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </div>
    <div class=""filler""></div>

        <div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h4 class=""modal-title"" id=""myModalLabel"">Purchase Duration</h4>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                    </div>
                    <div class=""modal-body"">
                        <p>For how long would you like to buy this product?</p>
                        <form>
                            <div class=""form-group"">
                                <label for=""select"">Select a subscription time:</label>
                                <select class=""form-control"" id=""select"">
                                    <option value=""3"">3 Months</option>
     ");
                WriteLiteral(@"                               <option value=""6"">6 Months</option>
                                    <option value=""9"">9 Months</option>
                                </select>
                            </div>
                        </form>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Kapat</button>
                        <button type=""button"" class=""btn btn-primary btn-satin-al-kaydet"" id=""btn-submit"">Tamam</button>
                    </div>
                </div>
            </div>
        </div>
    <script src=""/jquery-3.6.1.min.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/sweetalert2@11""></script>
    <script>
        $(document).ready(function(){
            $("".buybutton"").click(function(){
                var productId = $(this).attr(""ProId"")
                    $("".btn-satin-al-kaydet"").click(function(){
                        var selecte");
                WriteLiteral(@"dValue = $(""#select"").val()
                        $.ajax({
                            url: ""/Client/ClientHome/buy"",
                            method: ""post"",
                            datatype: ""json"",
                            data: {productId:productId, selectedValue:selectedValue},
                            success: function(result){
                                if(result.success)
                                {
                                    swal.fire(""Purchase successful!"").then((result) => {
                                    window.location.href = ""/Client/ClientHome/Index""
                                });

                                }
                                else
                                {
                                    swal.fire(result.message)
                                }
                            }

                        })
            })
        })
        })
    </script>
    
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
