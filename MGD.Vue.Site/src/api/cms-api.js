import Axios from "axios";

const cmsAxios = Axios.create({
  baseURL: "",
  headers: { "X-Requested-With": "XMLHttpRequest" },
});

export default {
  getRoutes() {
    return new Promise((resolve, reject) => {
      cmsAxios
        .get("/umbraco/api/route/GetAllRoutes?rootId=")
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
        .get("/umbraco/api/content/getpage?id=" + pageId)
        .then((response) => {
          resolve(response.data);
        })
        .catch((error) => {
          reject(error);
        });
    });
  },
};
