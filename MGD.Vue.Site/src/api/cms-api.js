import Axios from "axios";

const cmsAxios = Axios.create({
  baseURL: "",
  headers: { "X-Requested-With": "XMLHttpRequest" },
});

export default {
  getRoutes() {
    return new Promise((resolve, reject) => {
      cmsAxios
        .get("/umbraco/cmsapi/route/GetAllRoutes?rootId=")
        .then((response) => {
          resolve(response.data);
        })
        .catch((error) => {
          reject(error);
        });
    });
  },
  getPage(pageId) {
    return new Promise((resolve, reject) => {
      cmsAxios
        .get("/umbraco/cmsapi/pages/getpage?id=" + pageId)
        .then((response) => {
          resolve(response.data);
        })
        .catch((error) => {
          reject(error);
        });
    });
  },
  getMainMenu() {
    return new Promise((resolve, reject) => {
      cmsAxios
        .get("/umbraco/cmsapi/menu/getmainmenu")
        .then((response) => {
          resolve(response.data);
        })
        .catch((error) => {
          reject(error);
        });
    });
  },
};
