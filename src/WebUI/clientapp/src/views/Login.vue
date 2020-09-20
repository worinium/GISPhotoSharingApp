<template>
<!-- <div class="login container">

            <form class="was-validated">
                <div class="form-group">
                    <label for="uname" class="float-left">Username:</label>
                    <input type="text" class="form-control" id="uname" placeholder="Enter username" name="uname" required />
                    <div class="valid-feedback">Valid.</div>
                    <div class="invalid-feedback">Please fill out this field.</div>
                </div>
                <div class="form-group">
                    <label for="pwd" class="float-left">Password:</label>
                    <input type="password" class="form-control" id="pwd" placeholder="Enter password" name="pswd" required />
                    <div class="valid-feedback">Valid.</div>
                    <div class="invalid-feedback">Please fill out this field.</div>
                </div>
                <div class="form-group form-check">
                    <label class="form-check-label">
                        <input class="form-check-input" type="checkbox" name="remember" required />
                        I agree on blabla.
                        <div class="valid-feedback">Valid.</div>
                        <div class="invalid-feedback">Check this checkbox to continue.</div>
                    </label>
                </div>
                <button type="submit" class="btn btn-primary">Submit</button>
            </form>
        </div>
    </div>
</div> -->
<div>
    <div class="container">
        <form action="/action_page.php">

            <h2 style="text-align:center">Login with Social Media or Manually</h2>
            <div class="row">

                <div class="col-5">
                    <div class="card text-white bg-light navbar-light " style="max-width: 45rem; height:420px; margin-top:5vh">
                        <div class="card-header" style="color:green">Social login</div>
                        <div class="card-body">

                            <div class="row">
                                <div class="col-3 my-auto">
                                    <a href="#" class="btn btn-warning btn-lg btn-block">
                                        <i class="fa fa-facebook fa-fw"></i>
                                    </a>
                                    <a href="#" class="btn btn-primary btn-lg btn-block">
                                        <i class="fa fa-google fa-fw"></i>
                                    </a>
                                    <a href="#" class="btn btn-success btn-lg btn-block">
                                        <i class="fa fa-linkedin fa-fw"></i>
                                    </a>

                                    <a href="#" class="btn btn-secondary btn-lg btn-block">
                                        <i class="fa fa-twitter fa-fw"></i>
                                    </a>
                                </div>
                                <div class="col-9">
                                    <a href="#" class="btn btn-warning btn-lg btn-block"> Login with Facebook
                                    </a>
                                    <a href="#" class="btn btn-primary btn-lg btn-block"> Login with Google+
                                    </a>
                                    <a href="#" class="btn btn-success btn-lg btn-block"> LinkedIn
                                    </a>

                                    <a href="#" class="btn btn-secondary btn-lg btn-block"> Login with Twitter
                                    </a>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-2 my-auto">

                    <div>
                        <span class="vl-innertext">or</span>
                    </div>
                </div>
                <div class="col-5">
                    <div class="card text-white bg-light navbar-light " style="max-width: 45rem; height:420px; margin-top:5vh">
                        <div class="card-header" style="color:green">Manual Login</div>
                        <div class=" card-body">
                            <form class="was-validated">
                                <div class="form-group">
                                    <label for="uname" class="float-left">Username:</label>
                                    <input type="text" class="form-control" id="uname" placeholder="Enter username" name="uname" required />
                                    <div class="valid-feedback">Valid.</div>
                                    <div class="invalid-feedback">Please fill out this field.</div>
                                </div>
                                <div class="form-group">
                                    <label for="pwd" class="float-left">Password:</label>
                                    <input type="password" class="form-control" id="pwd" placeholder="Enter password" name="pswd" required />
                                    <div class="valid-feedback">Valid.</div>
                                    <div class="invalid-feedback">Please fill out this field.</div>
                                </div>
                                <div class="form-group form-check">
                                    <label class="form-check-label">
                                        <input class="form-check-input" type="checkbox" name="remember" required />
                                        I agree on blabla.
                                        <div class="valid-feedback">Valid.</div>
                                        <div class="invalid-feedback">Check this checkbox to continue.</div>
                                    </label>
                                </div>
                                <button type="submit" class="btn btn-primary">Submit</button>
                            </form>
                        </div>
                    </div>
                </div>

            </div>
        </form>
    </div>

    <div class="bottom-container">
        <div class="row">
            <div class="col">
                <a href="#" style="color:white" class="btn">Sign up</a>
            </div>
            <div class="col">
                <a href="#" style="color:white" class="btn">Forgot password?</a>
            </div>
        </div>
    </div>
</div>
</template>

<script scoped>
export default {
    data() {
        return {

        }
    },
    methods: {

    },
    created: {

    }

}
</script>

<style scoped>
/* .login {
    width: 500px;
}

@media (max-width: 880px) {

    .login {
        display: block;
        width: 100%;
        text-align: center;
    }

} */
</style>
