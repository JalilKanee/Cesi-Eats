<template>
 <div class="Register">
    <nav class="navbar navbar-expand-lg" style="background:black;height:80px;">
  <a class="navbar-brand" href="/home" style="margin-left:40px;font-size:40px;color:white;font-family:Helvetica">Cesi</a>
    <a class="navbar-brand" href="/home" style="font-size:40px;color:#64F58D;font-family:Helvetica">Eats</a>

  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>

  
</nav>

        <div>
        <section class="vh-100 gradient-custom" >
  <div class="container py-3 h-100" >
    <div class="row d-flex justify-content-center align-items-center h-100" >
      <div class="col-12 col-md-8 col-lg-6 col-xl-5">
        <div class="card" style="background:#fef9ef;box-shadow: rgba(0, 0, 0, 0.35) 0px 5px 15px;">
          <div class="card-body p-5 text-center" >
        <form style="font-weight: 700; padding-top: 20px;">
            <h3>Inscrivez-vous pour devenir un restaurateur</h3>
 
            <div class="form-group" style="padding-top: 20px;">

                <input  v-model="user.userName" ref="userName"  type="text" placeholder="Nom du restaurant" name="userName" />
            </div>
            <div class="form-group">
  
                <input v-model="user.email" ref="email" type="email" placeholder="Address Email" name="email" />
            </div>
            <div class="form-group">

                <input v-model="user.password" ref="psw" type="password" placeholder="Mot de passe" id="typepass" name="psw" />
                <i class="bi bi-eye-slash" style="" id="togglePassword" @click="Toggle()"></i>
                       
            </div>
            <div class="form-group">

                <input v-model="user.repeatPassword" ref="psw-repeat" type="password" placeholder="Confirmer le mot de passe" id="typepass2" name="psw-repeat" />
             
                       
            </div>
             
            <div class="form-group">
   
                <input required placeholder="Numéro de téléphone" type="text" name="phone"  v-model="user.Phone"/>
            </div>
            <div class="form-group">
         
                <input required placeholder="Carte de crédit" type="numeric" name="creditCard" v-model="user.creditCard" />
            </div>
            <div class="form-group">
               
                <input required placeholder="Adresse" type="text" name="address" v-model="user.Address" />
            </div>

 
            
 
            <button type="button" class="btn btn-dark btn-lg btn-block"  v-on:click="signup">S'inscrire</button>
 
            <p class="text-center" style="padding-top: 20px;"><router-link  to="/login">Vous êtes déjà un restaurateur ? Se Connecter</router-link></p>

 
        </form>
        </div>
        </div>
        </div>
        </div>
        </div>
        </section>
 </div>
        <div style="padding-top:180px;">
<div><link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"></div>


<footer data-aos="fade-up" class="text-light">
    <div class="container">
      <div class="row">
        <div class="col-md-3 col-lg- col-xl-3">
          <strong><h5>
            À propos
          </h5></strong>
          <hr class="bg-white mb-2 mt-0 d-inline-block mx-auto w-25">
          <p class="mb-0">
            Cesi Eats est un service de livraison de plats cuisinés lancé par 
            A4 Oran en 2022 et basé à Oran, en Algérie. Les commandes 
            sont prises via le site web de Cesi Eats auprès 
            des restaurants partenaires et sont livrées par des coursiers indépendants.
          </p>
        </div>
        <div class="col-md-4 col-lg-3 col-xl-3">
          <strong><h5>
            Contact
          </h5></strong>
          <hr class="bg-white mb-2 mt-0 d-inline-block mx-auto w-25">
          <ul class="list">
            <li><i class="fa fa-envelope mr-2"></i> contact@cesieats.dz</li>
            <li><i class="fa fa-phone mr-2"></i> (+213) 077 77 77 77</li>
            <li><i class="fa fa-phone mr-2"></i> (+213) 077 77 77 77</li>
            <li><i class="fa fa-phone mr-2"></i> (+213) 077 77 77 77</li>
          </ul>
        </div>
        <div class="col-md-2 col-lg-2 col-xl-3 mx-auto">
           <strong><h5>
            Retrouvez-nous sur :
          </h5></strong>
          <hr class="bg-white mb-2 mt-0 d-inline-block mx-auto w-25">
          <ul class="list-unstyled">
            <li>
              <a href="#" class="fb btn" target="_blank" style="background-color: lightgray;color: white;"><i class="fa fa-facebook fa-fw fa-2x" style="" ></i></a>
            </li>
            <li>
              <br>
            <a href="#" class="twitter btn" target="_blank" style="background-color: lightgray;color: white;"><i class="fa fa-twitter fa-fw fa-2x"></i></a>
            </li>
            <li>
              <br>
            <a href="#" class="twitter btn" target="_blank" style="background-color: lightgray;color: white;"><i class="fa fa-instagram fa-fw fa-2x"></i></a>
            </li>
          </ul>
        </div>
        
        <div class="col">
          <center>
            <strong><p>Copyright © 2022. All rights reserved to Cesi Oran A4.</p></strong>
          </center>
          </div>
          </div>
          </div>
        </footer>
        </div>
    </div>

</template>

<script>
const axios = require('axios');
import sqlApi from '@/services/sqlApi.js'

export default ({
  // Properties returned from data() becomes reactive state
  // and will be exposed on `this`.
 data(){

    return{
       
        user:{ 
         userId:0,
         userName:"",
         email: "",
         password:"",
         repeatPassword:"",
         Phone:"",
         Address:"",
         creditCard:"",
         user_type:"Restorateur"
         },
    }
 },

 methods : {    
        back(){
            this.$router.push({ name : 'home'});
        },        
        checkValidation(){
            if(!this.user.userName){
                alert("Veuillez entrer votre nom !");
                return;
            }
               if(!this.user.email){                    
                alert("Veuillez entrer votre adresse mail !");
                return;
            }
             if(!/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(this.user.email)){
                alert("Veuillez enter une Adress mail valide !");
                return;
            }
              if(!this.user.password){                    
                alert("Password required!");
                return;
            }
              if(this.user.password != this.user.repeatPassword){                    
                alert("Les mots de passes ne correspondent pas  !");
                return;
            }
            return true;

        },
        signup(){
            if(this.checkValidation()){
                axios.post(this.$hostname +"/api/user/registration", this.user)
                    .then(response => {
                        if (response.data.userId > 0){
                            alert("Vous êtes maintenant inscrit(e)!")
                            .then(() => {
                                this.$router.push({name:"login"});
                    
                            });
                        }else{
                            alert("Error : Something went wrong.");
                        }
                    })
                    .catch(error=>{
                        if (error.response){
                            alert(error.response.data);
                        }
                    });
            }

        },
        Toggle() {
            var temp = document.getElementById("typepass") ;
            var temp2 = document.getElementById("typepass2");
            if (temp.type === "password" && temp2.type === "password") {
                temp.type = "text";
                temp2.type = "text";
                document.getElementById("togglePassword").className = "bi bi-eye-slash";

            }
            else {
                temp.type = "password";
                temp2.type = "password";
                document.getElementById("togglePassword").className = "bi bi-eye";

            }
        },

 },
 })
</script>
<style>
  @import '@/assets/css/RegisterRestaurateur.css';
</style>