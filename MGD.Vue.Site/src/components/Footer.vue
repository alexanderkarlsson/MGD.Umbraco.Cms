<template>
  <footer class="footer" role="contentinfo">
    <div class="container">
      <div class="columns">
        <div class="column">
          <FooterLinks v-if="footerLinksColumn1" :links="footerLinksColumn1" />
        </div>
        <div class="column">
          <FooterLinks :links="footerLinksColumn2" />
        </div>
        <div class="column">
          <FooterLinks :links="footerLinksColumn3" />
        </div>
        <div class="column"></div>
      </div>
      <div v-for="socialMedia in socialMedias" :key="socialMedia.id">
        <a :href="socialMedia.url">{{socialMedia.name}}</a>
      </div>
    </div>
  </footer>
</template>
<script>
import cmsApi from "@/api/cms-api";
import FooterLinks from "../components/FooterLinks.vue";
export default {
  name: "Footer",
  components: {
    FooterLinks
  },
  data() {
    return {
      footerLinksColumn1: [],
      footerLinksColumn2: [],
      footerLinksColumn3: [],
      socialMedias: []
    };
  },
  created() {
    cmsApi.getPage(1134).then(page => {
      if (page.FooterLinksColumn1 != null) {
        page.FooterLinksColumn1.forEach(link => {
          this.footerLinksColumn1.push({ url: link.Url, name: link.Name });
        });
      }
      if (page.FooterLinksColumn2 != null) {
        page.FooterLinksColumn2.forEach(link => {
          this.footerLinksColumn2.push({ url: link.Url, name: link.Name });
        });
      }
      if (page.FooterLinksColumn3 != null) {
        page.FooterLinksColumn3.forEach(link => {
          this.footerLinksColumn3.push({ url: link.Url, name: link.Name });
        });
      }
      if (page.SocialMedias != null) {
        page.SocialMedias.forEach(socialMedia => {
          this.socialMedias.push({
            key: socialMedia.Key,
            url: socialMedia.SocialMediaUrl,
            name: socialMedia.SocialMediaName,
            icon: socialMedia.SocialMediaIcon
          });
        });
      }
    });
  }
};
</script>
