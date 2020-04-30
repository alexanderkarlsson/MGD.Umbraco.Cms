module.exports = {
  devServer: {
    port: 7777,
    proxy: {
      "/umbraco/*": {
        target: "https://cmsapi.wipcore.se/",
      },
      "/media/*": {
        target: "https://cmsapi.wipcore.se/",
      },
    },
  },
};
