
export default {
    mode: 'universal',
    /*
    ** Headers of the page
    */
    head: {
        title: process.env.npm_package_name || '',
        meta: [
            { charset: 'utf-8' },
            { name: 'viewport', content: 'width=device-width, initial-scale=1' },
            { hid: 'description', name: 'description', content: 'A software engineer based in Manila. Logging solutions to various problems. A Microsoft Certified Solutions Developer ( MCSD ). A casual gamer and stock market enthusiast.' },
            { name: 'keywords', content: 'Software Engineer, MCSD, Manila, C#, HTML, CSS, JavaScript, Angular, Visual Studio, Code, Microsoft, Certified, Solutions, Developer, App, Builder' }
        ],
        link: [
            { rel: 'icon', type: 'image/x-icon', href: '/favicon.ico' }
        ],
        script: [
            { src: 'https://www.googletagmanager.com/gtag/js?id=UA-73407480-1' },
            { src: '/gvc.js' },
            { src: 'https://kit.fontawesome.com/cd6c4c1925.js' }
        ]
    },
    /*
    ** Customize the progress-bar color
    */
    loading: { color: '#fff' },
    /*
    ** Global CSS
    */
    css: [
        '@/assets/styles/main.scss'
    ],
    /*
    ** Plugins to load before mounting the App
    */
    plugins: [
    ],
    /*
    ** Nuxt.js dev-modules
    */
    buildModules: [
    ],
    /*
    ** Nuxt.js modules
    */
    modules: [
        // Doc: https://bootstrap-vue.js.org/docs/
        'bootstrap-vue/nuxt',
        // Doc: https://axios.nuxtjs.org/usage
        '@nuxtjs/axios',
        '@nuxtjs/pwa',
    ],
    /*
    ** Axios module configuration
    ** See https://axios.nuxtjs.org/options
    */
    axios: {
        proxy: true // Can be also an object with default options
    },
    /*
    ** Build configuration
    */
    build: {
        /*
        ** You can extend webpack config here
        */
        extend(config, ctx) {
        }
    }
}