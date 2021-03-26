#pragma checksum "C:\Users\BS573\Desktop\BS0846\DemoChat\DemoChat\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd69ac66ad603b0fbe063180fc7d91e9178ab703"
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
#line 1 "C:\Users\BS573\Desktop\BS0846\DemoChat\DemoChat\Views\_ViewImports.cshtml"
using DemoChat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BS573\Desktop\BS0846\DemoChat\DemoChat\Views\_ViewImports.cshtml"
using DemoChat.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd69ac66ad603b0fbe063180fc7d91e9178ab703", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc133d8d043a901c166f536c1e6db0a170241dfb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\BS573\Desktop\BS0846\DemoChat\DemoChat\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    //string url = "https://cdn.jsdelivr.net/npm/@aspnet/signalr@1.0.0-rc1-update1/dist/browser/signalr.min.js";
    string url = "../../js/signalr.min.js";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .chat {
        margin-top: auto;
        margin-bottom: auto;
    }

    .card {
        height: 500px;
        border-radius: 15px !important;
        background-color: rgba(0,0,0,0.4) !important;
    }

    .contacts_body {
        padding: 0.75rem 0 !important;
        overflow-y: auto;
        white-space: nowrap;
    }

    .msg_card_body {
        overflow-y: auto;
    }

    .card-header {
        border-radius: 15px 15px 0 0 !important;
        border-bottom: 0 !important;
    }

    .card-footer {
        border-radius: 0 0 15px 15px !important;
        border-top: 0 !important;
    }

    .container {
        align-content: center;
    }

    .search {
        border-radius: 15px 0 0 15px !important;
        background-color: rgba(0,0,0,0.3) !important;
        border: 0 !important;
        color: white !important;
    }

        .search:focus {
            box-shadow: none !important;
            outline: 0px !important;
        }

    ");
            WriteLiteral(@".type_msg {
        background-color: rgba(0,0,0,0.3) !important;
        border: 0 !important;
        color: white !important;
        height: 60px !important;
        overflow-y: auto;
    }

        .type_msg:focus {
            box-shadow: none !important;
            outline: 0px !important;
        }

    .attach_btn {
        border-radius: 15px 0 0 15px !important;
        background-color: rgba(0,0,0,0.3) !important;
        border: 0 !important;
        color: white !important;
        cursor: pointer;
    }

    .send_btn {
        border-radius: 0 15px 15px 0 !important;
        background-color: rgba(0,0,0,0.3) !important;
        border: 0 !important;
        color: white !important;
        cursor: pointer;
    }

    .search_btn {
        border-radius: 0 15px 15px 0 !important;
        background-color: rgba(0,0,0,0.3) !important;
        border: 0 !important;
        color: white !important;
        cursor: pointer;
    }

    .contacts {
        list-s");
            WriteLiteral(@"tyle: none;
        padding: 0;
    }

        .contacts li {
            width: 100% !important;
            padding: 5px 10px;
            margin-bottom: 15px !important;
        }

    .active {
        background-color: rgba(0,0,0,0.3);
    }

    .user_img {
        height: 70px;
        width: 70px;
        border: 1.5px solid #f5f6fa;
    }

    .user_img_msg {
        height: 40px;
        width: 40px;
        border: 1.5px solid #f5f6fa;
    }

    .img_cont {
        position: relative;
        height: 70px;
        width: 70px;
    }

    .img_cont_msg {
        height: 40px;
        width: 40px;
    }

    .online_icon {
        position: absolute;
        height: 15px;
        width: 15px;
        background-color: #4cd137;
        border-radius: 50%;
        bottom: 0.2em;
        right: 0.4em;
        border: 1.5px solid white;
    }

    .offline {
        background-color: #c23616 !important;
    }

    .user_info {
        margin-top: auto");
            WriteLiteral(@";
        margin-bottom: auto;
        margin-left: 15px;
    }

        .user_info span {
            font-size: 20px;
            color: white;
        }

        .user_info p {
            font-size: 10px;
            color: rgba(255,255,255,0.6);
        }

    .video_cam {
        margin-left: 50px;
        margin-top: 5px;
    }

        .video_cam span {
            color: white;
            font-size: 20px;
            cursor: pointer;
            margin-right: 20px;
        }

    .msg_cotainer {
        margin-top: auto;
        margin-bottom: auto;
        margin-left: 10px;
        border-radius: 25px;
        background-color: #82ccdd;
        padding: 10px;
        position: relative;
    }

    .msg_cotainer_send {
        margin-top: auto;
        margin-bottom: auto;
        margin-right: 10px;
        border-radius: 25px;
        background-color: #78e08f;
        padding: 10px;
        position: relative;
    }

    .msg_time {
        positio");
            WriteLiteral(@"n: absolute;
        left: 0;
        bottom: -15px;
        color: rgba(255,255,255,0.5);
        font-size: 10px;
    }

    .msg_time_send {
        position: absolute;
        right: 0;
        bottom: -15px;
        color: rgba(255,255,255,0.5);
        font-size: 10px;
    }

    .msg_head {
        position: relative;
    }

    #action_menu_btn {
        position: absolute;
        right: 10px;
        top: 10px;
        color: white;
        cursor: pointer;
        font-size: 20px;
    }

    .action_menu {
        z-index: 1;
        position: absolute;
        padding: 15px 0;
        background-color: rgba(0,0,0,0.5);
        color: white;
        border-radius: 15px;
        top: 30px;
        right: 15px;
        display: none;
    }

        .action_menu ul {
            list-style: none;
            padding: 0;
            margin: 0;
        }

            .action_menu ul li {
                width: 100%;
                padding: 10px 15px;
   ");
            WriteLiteral(@"             margin-bottom: 5px;
            }

                .action_menu ul li i {
                    padding-right: 10px;
                }

                .action_menu ul li:hover {
                    cursor: pointer;
                    background-color: rgba(0,0,0,0.2);
                }

    .justify-content-end {
        background-color: #e09b1ecc;
        color: white;
        border-radius: 28px;
    }

    .justify-content-start {
        background-color: #ff005e6b;
        color: white;
        border-radius: 28px;
    }

    ul {
        list-style-type: none;
    }
</style>
<script");
            BeginWriteAttribute("src", " src=\"", 5961, "\"", 5971, 1);
#nullable restore
#line 271 "C:\Users\BS573\Desktop\BS0846\DemoChat\DemoChat\Views\Home\Index.cshtml"
WriteAttributeValue("", 5967, url, 5967, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></script>\r\n");
            WriteLiteral(@"<link href=""../../css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""../../js/bootstrap.min.js""></script>
<script src=""../../js/jquery.min.js""></script>

<!------ Include the above in your HEAD tag ---------->
<div class=""container-fluid h-100"">
    <div class=""row justify-content-center h-100"">
        <div class=""col-md-4 col-xl-3 chat"">
            <div class=""card mb-sm-3 mb-md-0 contacts_card"">
                <div class=""card-header"">
                    <div class=""input-group"">
                        <input type=""text"" placeholder=""Search...""");
            BeginWriteAttribute("name", " name=\"", 6873, "\"", 6880, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control search"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text search_btn""><i class=""fas fa-search""></i></span>
                        </div>
                    </div>
                </div>
                <div class=""card-body contacts_body"">
                    <ui class=""contacts"">
                        <div id=""onlineUsersList""></div>
                    </ui>
                </div>
                <div class=""card-footer""></div>
            </div>
        </div>
        <div class=""col-md-8 col-xl-6 chat"">
            <div class=""card"">
                <div class=""card-header msg_head"">
                    <div class=""d-flex bd-highlight"">
                        <div class=""user_info"">
                            <span>Chat with : <span id=""chat-with-name""></span><input type=""hidden"" id=""chat-with-id""/></span>
                        </div>
                    </div>
                </div>
    ");
            WriteLiteral(@"            <div class=""card-body msg_card_body"">
                    <ul>
                        <li id=""messageListId""></li>
                    </ul>
                </div>
                <div class=""card-footer"">
                    <div class=""input-group"">
                        <div class=""input-group-append"">
                            <span class=""input-group-text attach_btn""><i class=""fas fa-paperclip""></i></span>
                        </div>
                        <textarea");
            BeginWriteAttribute("name", " name=\"", 8411, "\"", 8418, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control type_msg"" id=""messageInput"" placeholder=""Type your message......"">
                         </textarea>
                        <div class=""input-group-append"">
                            <span class=""input-group-text send_btn"" id=""sendButton""><i class=""fas fa-location-arrow""></i></span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""clearfix""></div>
</div>
<script>
    ""use strict"";

    var username = prompt('Enter your name:', '');
    $(""#userName"").text('Hi! ' + username);
    const connection = new signalR.HubConnectionBuilder()
        .configureLogging(signalR.LogLevel.Debug)
        .withUrl(""http://localhost:20862/Index?name="" + username)
        .configureLogging(signalR.LogLevel.Information)
        .build();
    //function conStart() {
    //    if ($(""#userName"").val().trim() == null) {
    //        alert(""Type your name plaese!"");
    //        return;
");
            WriteLiteral(@"    //    }
        connection.start().then(() => {
        });
    //}
    //define unique id for send message
    var receiverId = function (id,name) {
        $('#chat-with-name').text(name);
        $('#chat-with-id').val(id);
    }
    var sendMessage = function () {
        const message = document.getElementById(""messageInput"").value;
        connection.invoke(""SendMessage"", message, $('#chat-with-id').val()).then((result) => {
        }).catch(err => console.error(err.toString()));
        event.preventDefault();
        $(""#messageInput"").val('');
    }
    document.getElementById(""sendButton"").addEventListener(""click"", event => {
        sendMessage();
    });
    $(""#messageInput"").keydown(function (e) {
        if (e.keyCode == 13) {
            sendMessage();
            e.preventDefault();
        }
    });


    connection.on(""UpdateUserList"", function (userc) {
        console.log(userc);
        $('#onlineUsersList').empty();

        $.map(JSON.parse(userc), fu");
            WriteLiteral(@"nction (val, k) {
            console.log('Key: ' + k + ' Value: ' + val + ';');
           // var userinfo = ""User Name: <b>"" + k + ""</b>, Connections: "" + val;

            // $('#onlineUsersList').append('<li onclick=receiverId(' + ""'"" + val + ""','"" + k + ""'"" + ')>' + k + '</li>');
            //debugger;
            //var v = $('#chat-with-id').val().trim();
            if (username !== k) {


                $('#onlineUsersList').append('<li class= ""active"" onclick=receiverId(' + ""'"" + val + ""','"" + k + ""'"" + ')>' +
                    '<div class=""d-flex bd-highlight"">' +
                    '<div class=""img_cont"">' +
                    '<img src=""../../img/user.png"" alt=""find and solve"" class=""rounded-circle user_img"">' +
                    '<span class=""online_icon""></span></div>' +
                    '<div class=""user_info"">' +
                    '<span>' + k + '</span>' +
                    '<p>' + val + '</p></div> </div></li>'
                );
            }
        })
 ");
            WriteLiteral(@"   });
   
    connection.on(""OwnMessage"", (message) => {
        console.log('ownmessage');
        console.log(message);
        $('#messageListId').append('<li><div class=""d-flex justify-content-end mb-4"">' +
            '<div class= """"msg_cotainer"">Me: ' + message + '<span class= ""msg_time_send"" ></span></div >' +
            '<div class=""img_cont_msg"">' +
            '<img src=""../../img/user.png"" alt=""find and solve"" class=""rounded-circle user_img_msg""> </div> </div></li>')
    });
    connection.on(""ReceiveMessage"", (message, senderId) => {
        console.log(senderId);
        $('#chat-with-name').text(senderId.userName);
        $('#messageListId').append('<li><div class=""d-flex justify-content-start mb-4"">' +
            '<div class=""img_cont_msg"">' +
            '<img src=""../../img/user.png"" alt=""find and solve"" class=""rounded-circle user_img_msg""> </div> ' +
            '<div class= """"msg_cotainer"">'+ senderId.userName + ': ' + message + '<span class= ""msg_time_send"" ></span></di");
            WriteLiteral("v >\' +\r\n            \'</div ></li>\')\r\n    });\r\n</script>");
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
