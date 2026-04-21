require 'nanoc/helpers/link_to'
require 'redcarpet'

use_helper Nanoc::Helpers::LinkTo

module RepoReadmeHelper
  def repo_readme_html
    markdown = File.read(File.expand_path('../../README.md', __dir__))
    renderer = Redcarpet::Render::HTML.new(hard_wrap: true)
    parser = Redcarpet::Markdown.new(
      renderer,
      autolink: true,
      fenced_code_blocks: true,
      no_intra_emphasis: true,
      strikethrough: true,
      tables: true
    )

    parser.render(markdown)
  end
end

use_helper RepoReadmeHelper
