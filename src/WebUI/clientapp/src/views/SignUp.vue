<template>
<div class="login container">
    <div class="card text-white bg-light navbar-light " style="max-width: 45rem; margin-top:5vh">
        <div class="card-header" style="color:green">Sign Up</div>
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
.login {
    width: 500px;
}

@media (max-width: 880px) {

    .login {
        display: block;
        width: 100%;
        text-align: center;
    }

}
</style>
