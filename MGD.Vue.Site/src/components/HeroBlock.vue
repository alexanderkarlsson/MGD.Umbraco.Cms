<template>
  <section
    class="hero hero-background is-large is-black is-bold has-background"
    v-bind:style="{ backgroundImage: 'url(' + bgImageUrl + ')' }"
  >
    <div class="hero-body">
      <div class="container">
        <h1 class="title is-family-secondary">{{ heading }}</h1>
        <div class="subtitle" v-html="text"></div>
      </div>
    </div>
  </section>
</template>
<script>
export default {
  name: "HeroBlock",
  props: {
    heading: String,
    text: String,
    bgImageUrl: String,
    blockType: String
  }
};
</script>
