function showPassword(){
var pswd = document.getElementById("password");
if(pswd.type==="password"){
    pswd.type="text";
}else{
    pswd.type="password";
}
}
function Uyari(input){
    var btn = document.getElementById("uyari");
    var pswd = document.getElementById("password").value;
    var id = document.getElementById("username").value;
    var tiklandi = false;
    btn.addEventListener("click",function(){
        tiklandi = true;
    });
    if(tiklandi=true){
        if(((pswd==="")||(id===""))||(pswd==="")&&(id==="")){
            alert("Lütfen gerekli alanlari doldurunuz!!");
            return false;
        }else{
            return true;
        }
    }

      

}