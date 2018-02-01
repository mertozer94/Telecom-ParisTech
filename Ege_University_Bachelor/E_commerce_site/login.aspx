<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <main id="authentication" class="inner-bottom-md">
            <div class="container">
                <div class="row">

                    <div class="col-md-6">
                        <section class="section sign-in inner-right-xs">
                            <h2 class="bordered">Giris Yap</h2>
                            <h2 class="bordered">
                                <asp:Label ID="Label1" runat="server" ForeColor="#FF3300" Text=""></asp:Label>
                            </h2>

                                <div class="field-row">
                                    <label>Email<asp:TextBox ID="TextBox1" runat="server" TabIndex="1" ToolTip="Kayıtlı olduğunuz e-mail adresini giriniz."></asp:TextBox>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Lütfen geçerli bir e-mail adresi giriniz." ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="TextBox1"></asp:RegularExpressionValidator>
                                    </label>
                                    &nbsp;
                                </div><!-- /.field-row -->
                                <div class="field-row">
                                    <label>Şifre<asp:TextBox ID="TextBox2" TextMode="Password"  runat="server" TabIndex="2" ToolTip="Lütfen kayıtlı olduğunuz şifrenizi giriniz."></asp:TextBox>
                                    </label>
                                    &nbsp;
                                </div><!-- /.field-row -->
                                <div class="field-row clearfix">
                                    <span class="pull-left">
                                        <label class="content-color"><input type="checkbox" class="le-checbox auto-width inline"> <span class="bold">Beni hatırla</span></label>
                                    </span>
                                    <span class="pull-right">
                                        <a href="#">Şifrenizi mi unuttunuz?</a>
                                    </span>
                                </div>
                            <asp:LoginView ID="LoginView1" runat="server">
                                <AnonymousTemplate>
                                <div class="buttons-holder">
                                    <button  runat="server" id="girisYap" type="submit"  OnServerClick="girisYap_OnClick" class="le-button huge">Giriş yap.</button>
                                </div><!-- /.buttons-holder -->
                                     </AnonymousTemplate>
                                <LoggedInTemplate>
                                    <div class="buttons-holder">
                                        Zaten giris yapmis durumdasiniz.
                                        </div>
                                </LoggedInTemplate>
                                </asp:LoginView>
                            <!-- /.cf-style-1 -->
                        </section><!-- /.sign-in -->
                    </div><!-- /.col -->
                </div><!-- /.row -->
            </div><!-- /.container -->
        </main>
</asp:Content>

