<template>
  <div id="app">
    <header>
      <TopNavigation />
    </header>
    <main>
      <router-view />
    </main>
  </div>
</template>

<script>
import TopNavigation from "./components/TopNavigation.vue";
export default {
  name: "App",
  components: {
    TopNavigation
  }
};
</script>

<style>
@import "~bulma/css/bulma.css";
</style>
