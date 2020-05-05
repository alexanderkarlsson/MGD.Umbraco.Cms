<template>
  <nav
    class="navbar"
    style="background-color: #e3dcd6;"
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
        <div class="navbar-start">
          <div
            class="navbar-item"
            v-bind:class="menuItem.children != null && menuItem.children.length > 0 ? 'has-dropdown is-hoverable' : ''"
            v-for="menuItem in mainMenu"
            :key="menuItem.id"
          >
            <router-link
              class="navbar-link"
              v-bind:class="menuItem.children != null && menuItem.children.length > 0 ? '' : 'is-arrowless'"
              :to="menuItem.url"
            >{{menuItem.name}}</router-link>
            <div class="navbar-dropdown">
              <router-link
                class="navbar-item"
                :to="menuItemChild.url"
                v-for="menuItemChild in menuItem.children"
                :key="menuItemChild.id"
              >{{menuItemChild.name}}</router-link>
            </div>
          </div>
        </div>
        <div class="navbar-end">
          <div class="navbar-item">
            <a
              class="button is-primary is-block-mobile"
              href="https://mardigras.digital/"
            >Landa i skogen!</a>
          </div>
        </div>
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
      mainMenu: []
    };
  },
  mounted() {
    cmsApi.getMainMenu().then(menu => {
      this.mainMenu = menu;
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
