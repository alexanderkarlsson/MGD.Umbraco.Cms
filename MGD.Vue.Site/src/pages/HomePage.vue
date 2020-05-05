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
      <TeasersBlock
        v-if="block.teasers != null && block.teasers.length > 0"
        :teasers="block.teasers"
        :isCompact="block.isCompact"
      ></TeasersBlock>
      <a
        v-if="block.blockType == 'bannerBlock'"
        :href="block.linkUrl"
        class="container banner-block"
        v-bind:style="{ backgroundImage: 'url(' + block.bgImageUrl + '?width=1000' + ')' }"
      >
        <img v-if="block.imageUrl" :src="block.imageUrl" alt />
      </a>
    </div>
  </div>
</template>

<script>
import cmsApi from "@/api/cms-api";
import HeroBlock from "../components/HeroBlock.vue";
import TeasersBlock from "../components/TeasersBlock.vue";
import { blocksy } from "../mixins/Blocks.js";
export default {
  name: "HomePage",
  components: {
    HeroBlock,
    TeasersBlock
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
      this.page = { blocks: [], heading: "" };
      cmsApi.getPage(this.pageId).then(currentPage => {
        this.page.heading = currentPage.Heading;
        if (currentPage.Blocks != null) {
          this.page.blocks = this.mapBlocks(currentPage.Blocks);
        }
      });
    }
  }
};
</script>
