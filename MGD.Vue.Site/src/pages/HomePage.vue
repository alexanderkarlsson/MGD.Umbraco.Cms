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
export default {
  name: "HomePage",
  components: {
    HeroBlock
  },
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
      let id = Number(this.pageId);
      let p = this.page;
      cmsApi.getPage(id).then(currentPage => {
        console.log(currentPage);
        p.heading = currentPage.Heading;
        if (currentPage.Blocks != null) {
          currentPage.Blocks.forEach(block => {
            let blockType = block.ContentType.Alias;
            if (blockType === "heroBlock") {
              p.blocks.push({
                heading: block.Heading,
                text: block.SubHeading,
                bgImageUrl: block.BackgroundImage
                  ? block.BackgroundImage.Url
                  : "",
                blockType: blockType
              });
            } else if (blockType === "wysiwygBlock") {
              p.blocks.push({
                body: block.Body,
                blockType: blockType
              });
            }
          });
        }
      });
    }
  }
};
</script>
