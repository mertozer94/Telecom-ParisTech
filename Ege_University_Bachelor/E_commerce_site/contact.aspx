<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="contact.aspx.cs" Inherits="contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <main id="contact-us" class="inner-bottom-md">
            <section class="google-map map-holder">
                <div id="map" class="map center"></div>
                <form role="form" class="get-direction">
                    <div class="container">
                        <div class="row">
                            <div class="center-block col-lg-10">
                                <div class="input-group">
                                    <input type="text" class="le-input input-lg form-control" placeholder="Enter Your Starting Point">
                                    <span class="input-group-btn">
                                        <button class="btn btn-lg le-button" type="button">Get Directions</button>
                                    </span>
                                </div><!-- /input-group -->
                            </div><!-- /.col-lg-6 -->
                        </div><!-- /.row -->
                    </div>
                </form>
            </section>
            <div class="container">
                <div class="row">

                    <div class="col-md-8">
                        <section class="section leave-a-message">
                            <h2 class="bordered">Leave a Message</h2>
                            <p>Maecenas dolor elit, semper a sem sed, pulvinar molestie lacus. Aliquam dignissim, elit non mattis ultrices, neque odio ultricies tellus, eu porttitor nisl ipsum eu massa.</p>
                           
                            
                                  
                                        <label>Ad Soyad*</label>
                            <br />
                            <asp:TextBox ID="adSoyad" runat="server" MaxLength="30" TabIndex="1" ToolTip="Ad Soyadınızı giriniz" Width="600px" AutoCompleteType="FirstName" OnTextChanged="adSoyad_TextChanged"></asp:TextBox>
                            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="adSoyad" ErrorMessage="Ad Soyad bilgisi boş bırakılamaz." ForeColor="#FF3300"></asp:RequiredFieldValidator>
                            <br /><br />
                                    
                                   
                                        <label>E-mail adresiniz*</label>
                            <br />
                            <asp:TextBox ID="TextBox4" runat="server" MaxLength="100" TabIndex="4" ToolTip="Örn; ornek@gmail.com" Width="600px" AutoCompleteType="Email" Height="24px"></asp:TextBox>
                            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="E-mail adresiniz bilgisi boş bırakılamaz." ForeColor="#FF3300"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox4" ErrorMessage="Lütfen geçerli bir e-mail adresi giriniz." ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                            <br /><br />
                                   
                               

                              
                                    <label>Konu                   
                                         
                                    </label>
                              <br />
                            <asp:TextBox ID="TextBox5" runat="server" Width="600px"></asp:TextBox>  
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox5" ErrorMessage="Konu boş bırakılamaz." ForeColor="#FF3300"></asp:RequiredFieldValidator>
                            <br /><br />
                                    &nbsp;
                               
                               
                                    <label>Mesajini giriniz</label>  <br />
                                    <asp:TextBox ID="TextBox3" runat="server" MaxLength="100" TabIndex="3" ToolTip="Kisa bir sekilde mesajinizi yaziniz" Width="600px" Height="85px" TextMode="MultiLine"></asp:TextBox>  
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Mesaj  boş bırakılamaz." ForeColor="#FF3300"></asp:RequiredFieldValidator>
                            <br />
                            &nbsp;
                                <div class="buttons-holder">
                                    <div class="buttons-holder">
                                   
                            <input runat="server" id="gonder" type="submit" value="Mail gonder" OnServerClick="mesajGonder_OnClick" class="le-button huge" /></div>
                                </div><!-- /.buttons-holder -->
                           

                        </section><!-- /.leave-a-message -->
                    </div><!-- /.col -->
                    <div class="col-md-4">
                        <section class="our-store section inner-left-xs">
                            <h2 class="bordered">Our Store</h2>
                            <address>
                                17 Princess Road <br />
                                London, Greater London <br />
                                NW1 8JR, UK
                            </address>
                            <h3>Hours of Operation</h3>
                            <ul class="list-unstyled operation-hours">
                                <li class="clearfix">
                                    <span class="day">Monday:</span>
                                    <span class="pull-right hours">12-6 PM</span>
                                </li>
                                <li class="clearfix">
                                    <span class="day">Tuesday:</span>
                                    <span class="pull-right hours">12-6 PM</span>
                                </li>
                                <li class="clearfix">
                                    <span class="day">Wednesday:</span>
                                    <span class="pull-right hours">12-6 PM</span>
                                </li>
                                <li class="clearfix">
                                    <span class="day">Thursday:</span>
                                    <span class="pull-right hours">12-6 PM</span>
                                </li>
                                <li class="clearfix">
                                    <span class="day">Friday:</span>
                                    <span class="pull-right hours">12-6 PM</span>
                                </li>
                                <li class="clearfix">
                                    <span class="day">Saturday:</span>
                                    <span class="pull-right hours">12-6 PM</span>
                                </li>
                                <li class="clearfix">
                                    <span class="day">Sunday</span>
                                    <span class="pull-right hours">Closed</span>
                                </li>
                            </ul>
                            <h3>Career</h3>
                            <p>If you're interested in employment opportunities at MediaCenter, please email us: <a href="mailto:contact@yourstore.com">contact@yourstore.com</a></p>
                        </section><!-- /.our-store -->
                    </div><!-- /.col -->
                </div><!-- /.row -->
            </div><!-- /.container -->
        </main>
</asp:Content>

