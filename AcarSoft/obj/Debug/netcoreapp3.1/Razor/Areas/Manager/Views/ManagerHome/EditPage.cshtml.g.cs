#pragma checksum "C:\Users\Ozan\Desktop\AcarSoft\AcarSoft\Areas\Manager\Views\ManagerHome\EditPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15ce1017ad1cc9876ee84ece7a58d48e6b6c85d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manager_Views_ManagerHome_EditPage), @"mvc.1.0.view", @"/Areas/Manager/Views/ManagerHome/EditPage.cshtml")]
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
#line 1 "C:\Users\Ozan\Desktop\AcarSoft\AcarSoft\Areas\Manager\Views\ManagerHome\EditPage.cshtml"
using Model.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15ce1017ad1cc9876ee84ece7a58d48e6b6c85d4", @"/Areas/Manager/Views/ManagerHome/EditPage.cshtml")]
    #nullable restore
    public class Areas_Manager_Views_ManagerHome_EditPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Manager>
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
#line 3 "C:\Users\Ozan\Desktop\AcarSoft\AcarSoft\Areas\Manager\Views\ManagerHome\EditPage.cshtml"
  
	Layout = "~/Areas/Manager/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"tr\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15ce1017ad1cc9876ee84ece7a58d48e6b6c85d43290", async() => {
                WriteLiteral(@"
	<meta charset=""UTF-8"">
	<title>Edit Profile</title>
	<style>
		form {
			max-width: 500px;
			margin: 0 auto;
			display: flex;
			flex-direction: column;
			align-items: center;
		}

		label {
			display: block;
			margin-top: 20px;
		}

		input[type=text], input[type=password], input[type=email] {
			width: 100%;
			padding: 10px;
			border: 2px solid #ccc;
			border-radius: 4px;
			box-sizing: border-box;
			margin-top: 10px;
			margin-bottom: 20px;
		}

		input[type=submit] {
			background-color: #4CAF50;
			color: white;
			padding: 12px 20px;
			border: none;
			border-radius: 4px;
			cursor: pointer;
		}

			input[type=submit]:hover {
				background-color: #45a049;
			}
		button{
			width: 125px;
			height: 50px;
		}
	</style>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15ce1017ad1cc9876ee84ece7a58d48e6b6c85d45045", async() => {
                WriteLiteral("\r\n\t<form>\r\n\t\t<img");
                BeginWriteAttribute("src", " src=\"", 969, "\"", 1001, 2);
                WriteAttributeValue("", 975, "/Pictures/", 975, 10, true);
#nullable restore
#line 55 "C:\Users\Ozan\Desktop\AcarSoft\AcarSoft\Areas\Manager\Views\ManagerHome\EditPage.cshtml"
WriteAttributeValue("", 985, Model.PhotoPath, 985, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"300\" height=\"300\"/>\r\n\t\t<h1>Edit Profile</h1>\r\n\t\t<label for=\"name\">Name:</label>\r\n\t\t<input type=\"text\" id=\"name\" required");
                BeginWriteAttribute("value", " value=\"", 1130, "\"", 1153, 1);
#nullable restore
#line 58 "C:\Users\Ozan\Desktop\AcarSoft\AcarSoft\Areas\Manager\Views\ManagerHome\EditPage.cshtml"
WriteAttributeValue("", 1138, Model.FullName, 1138, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
		<label for=""profile-photo"">Profile Photo:</label>
		<input type=""file"" id=""inputPhoto"" accept=""image/*"">
		<label for=""new-password"">New Password:</label>
		<input type=""password"" id=""password"" placeholder=""Please enter new password"">
		<label for=""confirm-password"">New Password Again:</label>
		<input type=""password"" id=""confirmPassword"" name=""confirm-password"" placeholder=""Please enter new password again"">
		<label for=""email"">Email:</label>
		<input type=""email"" id=""email"" required");
                BeginWriteAttribute("value", " value=\"", 1655, "\"", 1675, 1);
#nullable restore
#line 66 "C:\Users\Ozan\Desktop\AcarSoft\AcarSoft\Areas\Manager\Views\ManagerHome\EditPage.cshtml"
WriteAttributeValue("", 1663, Model.Email, 1663, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
		<div>
			<button type=""button"" class=""alert-danger"" id=""logout"">Log Out</button>
			<button type=""button"" class=""alert-success"" id =""savechanges"">Save Changes</button>
		</div>
	</form>
	<script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>
	<script src=""/jquery-3.6.1.min.js""></script>
	<script>
		$(document).ready(function(){
			$(""#logout"").click(function(){
				window.location.href = ""/Home/Index"";
			})
			$(""#savechanges"").click(function(){
				var newPassword = $(""#password"").val();
				var confirmPassword = $(""#confirmPassword"").val();
				if (newPassword != confirmPassword) {
					alert(""Passwords don't match!"");
					return false;
				}
				
				var formData = new FormData();
				if ($(""#inputPhoto"")[0].files.length > 0) {
					var file = $(""#inputPhoto"")[0].files[0];
					formData.append('file', file, file.name);
				} else {
					alert(""Please select an image file."");
					return false;
				}

				$.ajax({
				url: ""/Manager/ManagerHome/Manag");
                WriteLiteral(@"erPhoto"",
                method: ""post"",
                datatype: ""json"",
                data: formData,
                processData: false,
                contentType: false,
				success: function(result){
					if(!result.success)
					{
						swal(result.message)
					}
					else{
					var formModel = {
                                FullName: $(""#name"").val(),
                                Email: $(""#email"").val(),
                                Password: $(""#password"").val(),
								PhotoPath: result.photoPath
                            }
					$.ajax({
						url: ""/Manager/ManagerHome/ManagerModify"",
						method: ""post"",
						datatype: ""json"",
						data: { modifyingmanager: formModel },
						success: function(result){
							if(result.success){
								swal(""Saves have been successfully changed!"").then((result)=>{
									window.location.reload;
									window.location.href = ""/Manager/ManagerHome/Index"";
								})
							}
							else{
								swal(result.m");
                WriteLiteral("essage);\r\n\t\t\t\t\t\t\t}\r\n\t\t\t\t\t\t}\r\n\t\t\t\t\t})\r\n\t\t\t\t\t\t}\r\n\t\t\t\t}\r\n\t\t\t})\r\n\t\t\t})\r\n\t\t})\r\n\r\n\t</script>\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Manager> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
