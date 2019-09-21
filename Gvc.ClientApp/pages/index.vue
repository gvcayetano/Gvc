<template>
    <div>
        <Header />
        <b-container>

        </b-container>
    </div>
</template>

<script>
  import Header from '~/components/Header.vue'

  export default {
    components: {
      Header
    },
    head() {
      return {
        title: 'GVC - Software Engineer - MCSD'
      }
    },
    mounted() {
        this.$nextTick(() => {
            this.$nuxt.$loading.start();
            setTimeout(() => this.$nuxt.$loading.finish(), 500);
        })
    }
  }
</script>

<style>
</style>
