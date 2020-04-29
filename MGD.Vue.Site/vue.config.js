module.exports = {
  devServer: {
    port: 7777,
    proxy: {
      "/umbraco/*": {
        target: "http://localhost:17943/",
      },
      "/media/*": {
        target: "http://localhost:17943/",
      },
    },
  },
};
