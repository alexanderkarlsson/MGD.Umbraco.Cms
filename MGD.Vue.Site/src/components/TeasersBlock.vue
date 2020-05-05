<template>
  <div class="container">
    <div class="columns is-multiline">
      <div class="column is-one-third" v-for="teaser in teasers" :key="teaser.linkUrl">
        <router-link class="card" :to="teaser.linkUrl">
          <img v-if="teaser.bgImageUrl" class="card-image" :src="teaser.bgImageUrl + '?width=500'" />
          <div class="card-content">
            <p class="title">{{teaser.title}}</p>
            <div class="subtitle" v-html="teaser.text"></div>
          </div>
        </router-link>
      </div>
    </div>
  </div>
</template>
<script>
export default {
  name: "TeasersBlock",
  props: {
    isCompact: Boolean,
    teasers: {}
  }
};
</script>