import Vue from "vue";
import VueRouter from "vue-router";
import cmsApi from "@/api/cms-api";

Vue.use(VueRouter);
const routes = [];

const router = new VueRouter({
  mode: "history",
  linkActiveClass: "is-active",
  base: process.env.BASE_URL,
  routes,
});

export default router;
cmsApi.getRoutes().then((cmsRoutes) => {
  let dynamicRoutes = [];
  cmsRoutes.forEach((p) => {
    let alias = p.ContentType.Alias;
    alias = alias.charAt(0).toUpperCase() + alias.substr(1);
    let comp = () => import("../pages/" + alias + ".vue");
    dynamicRoutes.push({
      path: p.Url,
      name: p.Id.toString(),
      component: comp,
      props: { pageId: p.Id },
    });
  });
  router.addRoutes(dynamicRoutes);
});
