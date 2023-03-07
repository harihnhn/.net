<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signin.aspx.cs" Inherits="project_hotel.signin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Signin</title>
    <link rel="stylesheet" href="index.css"/>
</head>
<body>
    <h1 class="heading1">USER LOGIN</h1>
        <p class="heading1"><small>Admin login? <a href="">Click here</small></a></p>
        <div>
            <h1 class="heading2">Sign in</h1>
            <p class="heading2"><small>Sign in with your username and password</small></p>
            <br/>
            <br/>
            <label>Your username / Email Id : </label>
            <br/>            
            <input type="text" placeholder="Enter username"/>
            <br/>
            <br/>
            <label>password : </label>
            <br/>            
            <input type="password" placeholder="Enter password"/>
            <br/>
            <br/>
            <button type="button">Login</button>
            <br/>
            <p class="heading2"><small>New user? <a href="signup.aspx">Register here</a></small></p>
        </div>
</body>
</html>