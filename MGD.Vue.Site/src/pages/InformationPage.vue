<template>
  <div>
    <section class="hero" v-if="page.heading">
      <div class="hero-body">
        <div class="container">
          <h1 class="title">{{ page.heading }}</h1>
        </div>
      </div>
    </section>
    <section class="container" v-if="page.body">
      <div class="content" v-html="page.body"></div>
    </section>
  </div>
</template>

<script>
import cmsApi from "@/api/cms-api";
export default {
  name: "InformationPage",
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
      this.page = { heading: "", body: "" };
      let p = this.page;
      let id = Number(this.pageId);
      cmsApi.getPage(id).then(currentPage => {
        p.heading = currentPage.Heading;
        p.body = currentPage.Body;
      });
    }
  }
};
</script>