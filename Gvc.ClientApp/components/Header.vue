<template>
  <header>
    <nav class='navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3'>
      <div class="container">
        <a class="navbar-brand"><i class="fad fa-code"></i> GVC</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target=".navbar-collapse" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>
        <div class="navbar-collapse collapse d-sm-inline-flex flex-sm-row-reverse">
          <ul class="navbar-nav flex-grow">
            <li class="nav-item">
              <nuxt-link to="/" class="nav-link text-dark">
                Home
              </nuxt-link>
            </li>
            <li class="nav-item">
              <nuxt-link to="/about" class="nav-link text-dark">
                About
              </nuxt-link>
            </li>
          </ul>
        </div>
      </div>
    </nav>
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
