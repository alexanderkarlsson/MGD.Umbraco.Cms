export const blocksy = {
  methods: {
    mapBlocks(blocksSource) {
      let blocks = [];
      blocksSource.forEach((block) => {
        let blockType = block.ContentType.Alias;
        if (blockType === "heroBlock") {
          blocks.push({
            heading: block.Heading,
            text: block.SubHeading,
            bgImageUrl: block.BackgroundImage ? block.BackgroundImage.Url : "",
            blockType: blockType,
          });
        } else if (blockType === "wysiwygBlock") {
          blocks.push({
            body: block.Body,
            blockType: blockType,
          });
        } else if (blockType === "teasersBlock") {
          blocks.push(this.mapSourceToTeasersBlock(block));
        } else if (blockType === "bannerBlock") {
          blocks.push({
            bgImageUrl:
              block.BackgroundImage != null
                ? block.BackgroundImage.Url + "?width=400"
                : "",
            imageUrl: block.Image != null ? block.Image.Url : "",
            linkUrl: block.Link != null ? block.Link.Url : "",
            blockType: blockType,
          });
        }
      });
      return blocks;
    },
    mapSourceToTeasersBlock(source) {
      let block = { teasers: [], isCompact: false, blockType: "teasers" };
      block.isCompact = source.IsCompact;
      if (source.Teasers != null) {
        source.Teasers.forEach((teaser) => {
          if (teaser.ContentType.Alias == "manualTeaserBlock") {
            block.teasers.push({
              title: teaser.Title,
              text: teaser.Introduction,
              bgImageUrl:
                teaser.BackgroundImage != null
                  ? teaser.BackgroundImage.Url
                  : "",
              linkUrl: teaser.Link != null ? teaser.Link.Url : "",
            });
          } else if (
            teaser.ContentType.Alias == "mulipleTeaserBlock" &&
            teaser.Pages != null
          ) {
            teaser.Pages.forEach((pageTeaser) => {
              if (pageTeaser != null) {
                block.teasers.push({
                  title: pageTeaser.TeaserHeading || pageTeaser.Name,
                  text:
                    pageTeaser.TeaserIntroduction || pageTeaser.Introduction,
                  bgImageUrl:
                    pageTeaser.TeaserImage != null
                      ? pageTeaser.TeaserImage.Url
                      : "",
                  linkUrl: pageTeaser.Url,
                });
              }
            });
          }
        });
      }
      return block;
    },
  },
};
