<template>
<div id="app" style="background-color:light-gray">
    <nav class="navbar navbar-expand-sm bg-dark navbar-light static-top">
        <div class="row">
            <a class="navbar-brand ">
                <router-link to="/"><img src="http://placehold.it/150x50?text=Logo" alt="" class="mybrand" /></router-link>
            </a>
        </div>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse my-navs" id="navbarResponsive">
            <ul class="navbar-nav">
                <li class="nav-item active">
                    <a class="nav-link">
                        <router-link to="/">Home</router-link>
                        <span class="sr-only">(current)</span>
                    </a>
                </li>
                <li class="nav-item">
                    <a class="nav-link">
                        <router-link to="/About">About</router-link>
                    </a>
                </li>
                <li class="nav-item">
                    <a class="nav-link">
                        <router-link to="/MapRenderer">Map</router-link>
                    </a>
                </li>
            </ul>

            <ul class="navbar-nav ml-auto my-right-navs">
                <li class="nav-item">
                    <a class="nav-link">
                        <i class="fa fa-sign-out" aria-hidden="true"></i>
                        <router-link to="/SignUp">&nbsp;Sign Up</router-link>
                    </a>
                </li>
                <li class="nav-item">
                    <a class="nav-link">
                        <i class="fa fa-sign-in" aria-hidden="true"></i>
                        <router-link to="/Login">&nbsp;Login</router-link>
                    </a>
                </li>
            </ul>
        </div>
    </nav>
    <main class="container">
        <router-view />
    </main>

    <FooterSection />
</div>
</template>

<script>
import FooterSection from "@/components/Footer.vue";

export default {
    name: "footerSection",
    components: {
        FooterSection,
    },
    methods: {
        name() {},
    },
    computed: {
        sma() {
            return this.data;
        },
    },
    watch: {},
};
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
        color: #ffffff;

        background-color: #42b983;

        &.router-link-exact-active {
            color: #42b983;
        }
    }
}

.mybrand {
    margin-left: 130%;
    border-radius: 6px;
    height: 30px;
}

.my-navs {
    margin-left: 10%;
}

.my-right-navs {
    padding-right: 9%;
}

.my-navs a {
    color: #ffffff;
}

ul .nav-item .nav-link i {
    color: #ffffff;
}

@media only screen and (max-width: 1115px) {
    .mybrand {
        display: block;
        margin-left: 100%;
    }

    .my-navs {
        margin-left: 13%;
    }

    .my-right-navs {
        margin-right: 6%;
        color: red;
    }
}

@media only screen and (max-width: 998px) {
    .mybrand {
        display: block;
        margin-left: 40%;
    }

    .my-navs {
        margin-left: 6%;
    }

    .my-right-navs {
        margin-right: 0%;
    }
}

@media only screen and (max-width: 871px) {
    .mybrand {
        display: block;

        margin-left: 100%;
    }

    .my-navs {
        margin-left: 13%;
    }

    .my-right-navs {
        margin-right: 2%;
        color: red;
    }
}

@media only screen and (max-width: 768px) {

    /* For desktop: */
    .mybrand {
        display: block;

        margin-left: 125%;
    }

    .my-navs {
        margin-left: 16%;
    }

    .my-right-navs {
        margin-right: 9%;
        color: red;
    }
}

@media only screen and (max-width: 688px) {

    /* For desktop: */
    .mybrand {
        display: block;

        margin-left: 100%;
    }

    .my-navs {
        margin-left: 16%;
    }

    .my-right-navs {
        margin-right: 7%;
    }
}

@media only screen and (max-width: 604px) {
    .mybrand {
        display: block;
        margin-left: 44%;
    }

    .my-navs {
        margin-left: 7%;
    }

    .my-right-navs {
        margin: 0%;
    }
}
</style>
