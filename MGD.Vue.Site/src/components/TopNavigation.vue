<template>
  <nav
    class="navbar"
    style="background-image:linear-gradient(-90deg,#63BBE9 60%,#437BBD)"
    role="navigation"
    aria-label="main navigation"
  >
    <div class="container">
      <div class="navbar-brand">
        <a class="navbar-item" href="/">
          <img class="has-margin-top-6" src="../assets/blackBg.svg" width="100" />
        </a>
        <a
          role="button"
          class="navbar-burger"
          aria-label="menu"
          aria-expanded="false"
          data-target="navMenu"
        >
          <span aria-hidden="true"></span>
          <span aria-hidden="true"></span>
          <span aria-hidden="true"></span>
        </a>
      </div>
      <div id="navMenu" class="navbar-menu">
        <router-link
          v-for="route in cmsRoutes"
          :key="route.Name"
          class="navbar-item"
          :to="route.Url"
        >{{ route.Name }}</router-link>
      </div>
    </div>
  </nav>
</template>
<script>
import cmsApi from "@/api/cms-api";
export default {
  name: "TopNavigation",
  data() {
    return {
      cmsRoutes: []
    };
  },
  mounted() {
    cmsApi.getRoutes().then(cmsRoutes => {
      this.cmsRoutes = cmsRoutes.filter(function(r) {
        return r.Url != "/";
      });
    });
  }
};
document.addEventListener("DOMContentLoaded", () => {
  // Get all "navbar-burger" elements
  const $navbarBurgers = Array.prototype.slice.call(
    document.querySelectorAll(".navbar-burger"),
    0
  );

  // Check if there are any navbar burgers
  if ($navbarBurgers.length > 0) {
    // Add a click event on each of them
    $navbarBurgers.forEach(el => {
      el.addEventListener("click", () => {
        // Get the target from the "data-target" attribute
        const target = el.dataset.target;
        const $target = document.getElementById(target);

        // Toggle the "is-active" class on both the "navbar-burger" and the "navbar-menu"
        el.classList.toggle("is-active");
        $target.classList.toggle("is-active");
      });
    });
  }
});
</script>
