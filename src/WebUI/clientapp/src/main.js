import Vue from 'vue'
import App from './App.vue'
import './registerServiceWorker'
import router from './router'
import store from './store'

//import Mapbox from "mapbox-gl-vue";
import "bootstrap";
import "bootstrap/dist/css/bootstrap.min.css";
//import material-icon scss
import "font-awesome/css/font-awesome.min.css";
 
//defined as global component
Vue.component('VueFontawesome', require('vue-fontawesome-icon/VueFontawesome.vue').default);
 //Vue.use(Mapbox);
Vue.config.productionTip = false

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')
