import { HStesteTemplatePage } from './app.po';

describe('HSteste App', function() {
  let page: HStesteTemplatePage;

  beforeEach(() => {
    page = new HStesteTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
