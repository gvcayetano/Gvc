<template>
    <header>
        <b-navbar toggleable="sm" >
            <nuxt-link to="/">
                <b-navbar-brand>
                <i class="fad fa-code"></i> GVC
                </b-navbar-brand>
            </nuxt-link>

            <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>

            <b-collapse id="nav-collapse" is-nav>
                
                <b-navbar-nav class="ml-auto">
                    <b-nav-item to="/">Home</b-nav-item>
                    <b-nav-item to="/about" >About</b-nav-item>
                </b-navbar-nav>

            </b-collapse>
        </b-navbar>
    </header>
</template>

<script>
  export default {

  }
</script>

<style lang="scss" scoped>
    a.navbar-brand {
    white-space: normal;
    text-align: center;
    word-break: break-all;
}
</style>
