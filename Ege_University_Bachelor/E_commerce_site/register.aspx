<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <main id="authentication" class="inner-bottom-md">
	<div class="container">
		<div class="row">
			

			<div class="col-md-6">
				<section class="section register inner-left-xs">
					<h2 class="bordered">Yeni hesap Oluşturun</h2>
					<p>Kolay adımlarla yeni hesabınızı oluşturun.</p>
                    <p>
                        <label>Ad Soyad</label></p>
                    <p>
                            <asp:TextBox ID="adSoyad" runat="server" MaxLength="30" TabIndex="1" ToolTip="Ad Soyadınızı giriniz" Width="600px" AutoCompleteType="FirstName"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="adSoyad" ErrorMessage="Ad Soyad bilgisi boş bırakılamaz." ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    </p>
                    <span id="spnError" style="color: Red; display: none">*Valid characters: Alphabets and
space.</span>
                    <p>
                        <label>Eczane Adı</label></p>
                    <p>
                            <asp:TextBox ID="TextBox2" runat="server" MaxLength="30" TabIndex="2" ToolTip="Eczanenizin adını giriniz." Width="600px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Eczanenizin adı bilgisi boş bırakılamaz." ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    </p>
                    <p>
                        <label>Eczane Adresi</label></p>
                    <p>
                            <asp:TextBox ID="TextBox3" runat="server" MaxLength="100" TabIndex="3" ToolTip="Eczanenin tam adresini giriniz." Width="600px" Height="85px" TextMode="MultiLine"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Eczanenizin adresi bilgisi boş bırakılamaz." ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    </p>
                    <p>
                        <label>E-mail adresi</label></p>
                    <p>
                            <asp:TextBox ID="TextBox4" runat="server" MaxLength="100" TabIndex="4" ToolTip="Örn; ornek@gmail.com" Width="600px" AutoCompleteType="Email" Height="24px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="E-mail adresiniz bilgisi boş bırakılamaz." ForeColor="#FF3300"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox4" ErrorMessage="Lütfen geçerli bir e-mail adresi giriniz." ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </p>
                    <p>
                        <label>Telefon Numarası</label></p>
                    <p>
                            <asp:TextBox ID="telNumber" runat="server" MaxLength="11" TabIndex="5" ToolTip="Orn; 05..." Width="600px" AutoCompleteType="HomePhone"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="telNumber" ErrorMessage="Telefon numaranız bilgisi boş bırakılamaz." ForeColor="#FF3300"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Lütfen geçerli bir telefon numarası girin." ValidationExpression = "^[\d]{11,11}$" ForeColor="#FF3300" ControlToValidate="telNumber"></asp:RegularExpressionValidator>
                    </p>
                    <p>
                        <label>Şifre</label></p>
                    <p>
                            <asp:TextBox ID="TextBox6" TextMode="Password" runat="server" MaxLength="11" TabIndex="6" ToolTip="Şifreniz en azından bir rakam ve bir harf içermeli ve en az 6 karakter uzunluğunda olmalı." Width="600px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox6" ErrorMessage="Şifre bilgisi bilgisi boş bırakılamaz." ForeColor="#FF3300"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox6" ControlToValidate="TextBox7" ErrorMessage="Şifrenizin aynı olması gereklidir." ForeColor="#FF3300"></asp:CompareValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox6" ValidationExpression = "^[\s\S]{6,11}$" ErrorMessage="Şifreniz en az 6 karakterden oluşmalı." ForeColor="#FF3300"></asp:RegularExpressionValidator>
                    </p>
                    <p>
                        <label>Şifreyi tekrar giriniz</label></p>
                    <p>
                            <asp:TextBox ID="TextBox7" TextMode="Password" runat="server" MaxLength="11" TabIndex="7" ToolTip="Şifreniz en azından bir rakam ve bir harf içermeli ve en az 6 karakter uzunluğunda olmalı." Width="600px" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox7" ErrorMessage="Şifre bilgisi bilgisi boş bırakılamaz." ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    </p>
                    <div class="buttons-holder">
                                   
                            <input runat="server" id="KayitOl" type="submit" value="Kayit Ol" OnServerClick="KayitOl_OnClick" class="le-button huge" /></div><!-- /.buttons-holder -->
					</form>

					<h2 class="semi-bold">Bugün kaydolun ve bu özelliklere hemen sahip olun</h2>

					<ul class="list-unstyled list-benefits">
						<li>Hızlı gönderim</li>
						<li>Kargonuzun nerede olduğunu takip edebilirsiniz.</li>
						<li>Bütün ödemelerinizi takip edebilirsiniz</li>
					</ul>

				</section><!-- /.register -->

			</div><!-- /.col -->

		</div><!-- /.row -->
	</div><!-- /.container -->
</main><!-- /.authentication -->

</asp:Content>

