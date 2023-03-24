<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="project_hotel.signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>signup</title>
    <link rel="stylesheet" href="signup.css"/>
</head>
<body>
        <span class="heading1">
            <h1>USER REGISTRATION</h1> 
            <p><small>Please fill in the details to create an account with us.</small></p>
        </span>
        
        <div>
            <h1 class="heading2">SIGN UP</h1>
            <label>Name</label>
            <br/>
            <input type="text" placeholder="Enter Your Name">
            <br>
            <br>

            <label>Email</label>
            <br>
            <input type="text" placeholder="Enter Your Email Id">
            <br>
            <br>
            
            <label>Password</label>
            <br/>
            <input type="password" placeholder="Enter Your Password"/>
            <br/>
            <br/>

            <label>Confirm Password</label>
            <br>
            <input type="text" placeholder="Confirm Password">
            <br>
            <br>

            <label>Mobile Number</label>
            <br>
            <input type="text" placeholder="Enter Your Mobile Number">
            <br>
            <br>
            
            <p><small>By creating an account you agree to our <a href="">Terms & Privacy</a></small></p>
            <button type="button" onclick="sign_up()" id="submit">Register</button>
            <script>
                document.getElementById("submit").addEventListener("click", sign_up(){
                    int a=10;
                });
            </script>
        </div>
</body>
</html>