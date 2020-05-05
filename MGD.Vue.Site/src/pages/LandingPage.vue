<template>
  <div>
    <div v-for="block in page.blocks" :key="block.Key">
      <HeroBlock
        :heading="block.heading"
        :text="block.text"
        :bgImageUrl="block.bgImageUrl"
        v-if="block.blockType == 'heroBlock'"
      />
      <div class="container content" v-if="block.blockType == 'wysiwygBlock'" v-html="block.body"></div>
    </div>
  </div>
</template>

<script>
import cmsApi from "@/api/cms-api";
import HeroBlock from "../components/HeroBlock.vue";
import { blocksy } from "../mixins/Blocks.js";
export default {
  name: "LandingPage",
  components: {
    HeroBlock
  },
  mixins: [blocksy],
  data() {
    return {
      page: {}
    };
  },
  props: {
    pageId: Number
  },
  watch: {
    $route() {
      this.loadPage();
    }
  },
  created() {
    this.loadPage();
  },
  methods: {
    loadPage() {
      this.page = { blocks: [] };
      cmsApi.getPage(this.pageId).then(currentPage => {
        if (currentPage.Blocks != null) {
          this.page.blocks = this.mapBlocks(currentPage.Blocks);
        }
      });
    }
  }
};
</script>