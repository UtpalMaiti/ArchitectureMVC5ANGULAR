import { ALLTemplatePage } from './app.po';

describe('ALL App', function() {
  let page: ALLTemplatePage;

  beforeEach(() => {
    page = new ALLTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
