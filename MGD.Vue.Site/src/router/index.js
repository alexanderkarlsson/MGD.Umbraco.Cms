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
    let comp = () => import("../pages/" + p.alias + ".vue");
    dynamicRoutes.push({
      path: p.url,
      name: p.name,
      component: comp,
      props: { pageId: p.id },
    });
  });
  router.addRoutes(dynamicRoutes);
});
