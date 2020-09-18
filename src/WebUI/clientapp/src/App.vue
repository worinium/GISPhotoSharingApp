<template>
<div id="app">
    <div id="nav">
        <nav class="navbar navbar-expand-sm bg-light navbar-light static-top">
            <div class="row">
                <a class="navbar-brand">
                    <router-link to="/"><img src="http://placehold.it/150x50?text=Logo" alt=""></router-link>
                </a>

            </div> <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarResponsive">
                <ul class="navbar-nav">
                    <li class="nav-item active">
                        <a class="nav-link">
                            <router-link to="/">Home</router-link> <span class="sr-only">(current)</span>
                        </a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link">
                            <router-link to="/About">About</router-link>
                        </a>
                    </li>

                </ul>

                <ul class="navbar-nav ml-auto">
                    <li class="nav-item">
                        <a class="nav-link">
                            <span class="glyphicon glyphicon-user"></span>
                            <router-link to="/Login">Login</router-link>
                        </a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link">
                            <span class="glyphicon glyphicon-user"></span>
                            <router-link to="/SignUp">Sign Up</router-link>
                        </a>
                    </li>
                </ul>
            </div>
        </nav>
        <router-view />
    </div>
    <Footer />
</div>
</template>

<script>
import Footer from '@/components/Footer.vue'

export default {
    name: 'footer',
    components: {
        Footer
    }
}
</script>

<style lang="scss">
#app {
    font-family: Avenir, Helvetica, Arial, sans-serif;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    text-align: center;
    color: #2c3e50;
}

#nav {
    padding: 0 20px 0 20px;

    a {
        font-weight: bold;
        color: #2c3e50;

        &.router-link-exact-active {
            color: #42b983;
        }
    }
}
</style>
