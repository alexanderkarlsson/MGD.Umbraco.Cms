<template>
  <div id="app">
    <header>
      <TopNavigation />
    </header>
    <main>
      <router-view />
    </main>
    <Footer />
  </div>
</template>

<script>
import TopNavigation from "./components/TopNavigation.vue";
import Footer from "./components/Footer.vue";
export default {
  name: "App",
  components: {
    TopNavigation,
    Footer
  },
  watch: {
    $route(to) {
      document.title = to.meta.title || "Your Website";
    }
  }
};
</script>

<style>
@import "~bulma/css/bulma.css";
</style>
