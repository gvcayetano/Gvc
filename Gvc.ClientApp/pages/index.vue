<template>
  <div>
    <Header />
    <div class="container">
    </div>
  </div>
</template>

<script>
  import Header from '~/components/Header.vue'
  import Logo from '~/components/Logo.vue'

  export default {
    components: {
      Header,
      Logo
    },
    head() {
      return {
        title: 'GVC - Software Engineer - MCSD'
      }
    }
  }
</script>

<style>
</style>
