import Vue from "vue";
import Vuex from "vuex";
import cmsApi from "@/api/cms-api";

Vue.use(Vuex);
export default new Vuex.Store({
  state: {
    cmsRoutes: [],
  },
  mutations: {
    initCmsRoutes(state) {
      cmsApi.getRoutes(function(response) {
        state.cmsRoutes = response.data;
      });
    },
  },
  actions: {},
  modules: {},
});
