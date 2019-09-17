<template>
  <div>
    <Header />
    <div class="container">
      <div class="row">
        <div class="col-md-12">
          <h5>Hi!</h5>
          <p>You can call me 'Jayjay'. I'm a software engineer based in Manila. </p>
          <p>Here are some links to get to know me better:</p>
        </div>
      </div>
      <div class="row about-links" v-for="link in socialMediaLinks">
        <div class="col-md-12">
          <a class="about-links__url" :href="link.url" target="_blank">
            <i :class="link.fontAwesomeClass"></i>
            <span class="about-links__username">{{link.username}}</span>
          </a>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
  import Header from '~/components/Header.vue'
  export default {
    data() {
      return {
        socialMediaLinks: []
      }
    },
    components: {
      Header
    },
    head() {
      return {
        title: 'GVC - About'
      }
    },
    methods: {
      async getSocialMediaLinks() {
        this.socialMediaLinks = await this.$axios.$get('https://localhost:44374/api/about')
      }
    },
    mounted() {
      this.getSocialMediaLinks();
    }
  }
</script>

<style lang="scss" scoped>
    .about-links {
        &__url {
            display: inline-block;
            padding-bottom: 15px;
        }
        i {
            vertical-align: middle;
            font-size: 30px;
            margin-right: 5px;
        }
        &__username {
            vertical-align: middle;
        }
    }
</style>
