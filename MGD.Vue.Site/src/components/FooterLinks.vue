<template>
  <div class="menu">
    <ul class="menu-list" v-if="links && links.length > 0">
      <li>
        <a :href="link.url" v-for="link in links" :key="link.url">{{link.name}}</a>
      </li>
    </ul>
  </div>
</template>
<script>
export default {
  name: "FooterLinks",
  props: {
    links: {}
  }
};
</script>
